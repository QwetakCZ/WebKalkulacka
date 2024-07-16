using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculation
{
    public class Operation
    {
        public async Task<bool> CheckNumber(double[] numbers)
        {
            try
            {
                foreach (double number in numbers)
                {
                    //Kontrola jestli je number cislo
                    if (double.IsNaN(number))
                    {
                        return await Task.FromResult(false);
                    }
                }
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                SendError(ex);
                return await Task.FromResult(false);
            }
        }
        public async Task<bool> CheckOperation(string operation)
        {
            try
            {
                if (operation == "+" || operation == "-" || operation == "x" || operation == "/")
                {
                    return await Task.FromResult(true);
                }
                else
                {
                    return await Task.FromResult(false);
                }
            }
            catch (Exception ex)
            {
                SendError(ex);
                return await Task.FromResult(false);
            }
        }

        public double Plus(double[] numbers)
        {
            try
            {
                return numbers.Sum();
            }
            catch (Exception ex)
            {
                SendError(ex);
                return 0;
            }
        }

        public double Minus(double[] numbers)
        {
            try
            {
                double result = numbers[0];
                bool firstNumber = true;
                foreach (double number in numbers)
                {
                    if (firstNumber)
                    {
                        firstNumber = false;
                        continue;
                    }
                    result -= number;
                }
                return result;
            }
            catch (Exception ex)
            {
                SendError(ex);
                return 0;
            }
        }

        public double Multiply(double[] numbers)
        {
            try
            {
                double result = 1;
                foreach (double number in numbers)
                {
                    result *= number;
                }
                return result;
            }
            catch (Exception ex)
            {
                SendError(ex);
                return 0;
            }
        }

        public double Divide(double[] numbers)
        {
            try
            {
                double result = numbers[0];
                bool firstNumber = true;
                foreach (double number in numbers)
                {
                    if (firstNumber)
                    {
                        firstNumber = false;
                        continue;
                    }
                    if (number == 0)
                    {
                        return 0;
                        throw new DivideByZeroException();
                    }
                    result /= number;
                }
                return result;
            }
            catch (Exception ex)
            {
                SendError(ex);
                return 0;
            }
        }

        private void SendError(Exception exception)
        {
            Debug.WriteLine(exception.Message);
        }
    }


}
