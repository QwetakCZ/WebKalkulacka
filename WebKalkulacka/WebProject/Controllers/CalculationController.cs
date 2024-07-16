using MathCalculation;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebProject.Models;
namespace WebProject.Controllers
{
    public class CalculationController
    {
        private readonly Context _context;

        public CalculationController(Context context)
        {
            _context = context;
        }

        public async Task<List<Models.Calculation>> GetLastCalculation()
        {
            //Vraceni poslednich 10 zaznamu vypoctu
            return await _context.Calculations.OrderByDescending(x => x.Id).Take(10).ToListAsync();
        }

        public async Task<double> Result(double[] numbers, string operation)
        {
            MathCalculation.Operation math = new MathCalculation.Operation();
            var taskResult = await math.CheckNumber(numbers);

            if (!taskResult)
                taskResult = await math.CheckOperation(operation);

            if (!taskResult)
            {
                return 0;
            }
            var result = 0.0;
            switch (operation)
            {
                case "+":
                    result = math.Plus(numbers);
                    break;
                case "-":
                    result = math.Minus(numbers);
                    break;
                case "x":
                    result = math.Multiply(numbers);
                    break;
                case "/":
                    result = math.Divide(numbers);
                    break;
                default:
                    return 0;
            }
            try
            {
                var writeToDb = await _context.AddAsync(new Models.Calculation
                {
                    Numbers = numbers,
                    Operation = operation,
                    Result = result
                });
                await _context.SaveChangesAsync();
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }

            return await Task.FromResult(result);


           

        }
    }
}
