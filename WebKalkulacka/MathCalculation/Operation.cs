using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathCalculation.Models;
using MathCalculation.Services;


namespace MathCalculation
{
    public class Operation
    {
       
        public CalculationModel GetResult(CalculationModel model)
        {
            switch (model.Operation)
            {
                case Models.Operation.Plus:
                    return Plus(model);
                case Models.Operation.Minus:
                    return Minus(model);
                case Models.Operation.Multiply:
                    return Multiply(model);
                case Models.Operation.Divide:
                    return Divide(model);
                default:
                    return null;
            }

        }

        private CalculationModel Plus(CalculationModel model)
        {
            try
            {
                model.Result = model.Number1 + model.Number2;
                return model;
            }
            catch (Exception ex)
            {
                SendError(ex);
                return null;
            }
        }

        private CalculationModel Minus(CalculationModel model)
        {
            try
            {
                model.Result = model.Number1 - model.Number2;
                return model;
            }
            catch (Exception ex)
            {
                SendError(ex);
                return null;
            }
        }

        private CalculationModel Multiply(CalculationModel model)
        {
            try
            {
                model.Result = model.Number1 * model.Number2;
                return model;
            }
            catch (Exception ex)
            {
                SendError(ex);
                return null;
            }
        }

        private CalculationModel Divide(CalculationModel model)
        {
            try
            {
                if (model.Number2 == 0)
                {
                    throw new DivideByZeroException();
                }
                model.Result = model.Number1 / model.Number2;
                return model;
            }
            catch (Exception ex)
            {
                SendError(ex);
                return null;
            }
        }

        public static async Task SendError(Exception exception)
        {
            Debug.WriteLine(exception.Message);
            ErrorServices errorServices = new ErrorServices();
            await errorServices.SaveError(exception.Message);

        }
    }


}
