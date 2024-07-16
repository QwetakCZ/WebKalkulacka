using MathCalculation;
using MathCalculation.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebProject.Models;
using MathCalculation.Models;
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

        public async Task<double> AddToDbAsync(CalculationModel model)
        {

            try
            {
                Calculation dbModel = new Calculation
                {
                    Number1 = model.Number1,
                    Number2 = model.Number2,
                    Operation = (MathCalculation.Models.Operation)model.Operation,
                    Result = model.Result
                };

                await _context.Calculations.AddAsync(dbModel);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MathCalculation.Operation.SendError(ex);
            }

            return await Task.FromResult(0);




        }
    }
}
