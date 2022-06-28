using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppTest;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class CaculateTest
    {
        // Declare 
        ICalculate _calculate;
        [TestInitialize]
        public void TestInitialize()
        {
            _calculate = new Calculate();
        }

        [TestMethod]
        public void Add()
        {
            var result = _calculate.Add(10, 11);
            Assert.AreEqual(21, result);
        }
        [TestMethod]
        public void Sub()
        {
            var result = _calculate.Sub(10, 11);
            Assert.AreEqual(-1, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Mock<checkEmployee> chk = new Mock<checkEmployee>();
            chk.Setup(x => x.checkEmp()).Returns(true);

            processEmployee obje = new processEmployee();
            Assert.AreEqual(obje.insertEmployee(chk.Object), true);
        }
    }
}
