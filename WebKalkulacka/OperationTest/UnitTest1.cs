using MathCalculation;
using MathCalculation.Models;
namespace OperationTest
{
    [TestClass]
    public class UnitTest1
    {
        private MathCalculation.Operation _operation;

        [TestInitialize]
        public void TestInitialize()
        {
            _operation = new MathCalculation.Operation();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _operation = null;
        }

        [TestMethod]
        public void TestPlus()
        { 
            Assert.AreEqual(2, _operation.GetResult(new CalculationModel { Number1 = 1, Number2 = 1, Operation = MathCalculation.Models.Operation.Plus }).Result);
            Assert.AreEqual(5.25m, _operation.GetResult(new CalculationModel { Number1 = 5m, Number2 = 0.25m, Operation = MathCalculation.Models.Operation.Plus }).Result);
            Assert.AreEqual(100.2m, _operation.GetResult(new CalculationModel { Number1 = 100.1m, Number2 = 0.1m, Operation = MathCalculation.Models.Operation.Plus }).Result);

        }

        [TestMethod]
        public void TestMinus()
        {
            Assert.AreEqual(2, _operation.GetResult(new CalculationModel { Number1 = 4, Number2 = 2, Operation = MathCalculation.Models.Operation.Minus }).Result);
            Assert.AreEqual(5.25m, _operation.GetResult(new CalculationModel { Number1 = 7m, Number2 = 1.75m, Operation = MathCalculation.Models.Operation.Minus }).Result);
            Assert.AreEqual(100.2m, _operation.GetResult(new CalculationModel { Number1 = 102, Number2 = 1.8m, Operation = MathCalculation.Models.Operation.Minus }).Result);

        }

        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(2, _operation.GetResult(new CalculationModel { Number1 = 2, Number2 = 1, Operation = MathCalculation.Models.Operation.Multiply }).Result);
            Assert.AreEqual(0, _operation.GetResult(new CalculationModel { Number1 = 5m, Number2 = 0m, Operation = MathCalculation.Models.Operation.Multiply }).Result);
            Assert.AreEqual(103.02m, _operation.GetResult(new CalculationModel { Number1 = 10.1m, Number2 = 10.2m, Operation = MathCalculation.Models.Operation.Multiply }).Result);

        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(3, _operation.GetResult(new CalculationModel { Number1 = 9, Number2 = 3, Operation = MathCalculation.Models.Operation.Divide }).Result);
            Assert.AreEqual(2.5m, _operation.GetResult(new CalculationModel { Number1 = 5m, Number2 = 2m, Operation = MathCalculation.Models.Operation.Divide }).Result);

        }

        [TestMethod]
        public void TestDivideByZero()
        { 
            var result = _operation.GetResult(new CalculationModel { Number1 = 5, Number2 = 0, Operation = MathCalculation.Models.Operation.Divide });
            Assert.IsNull(result);
        }
    }
}