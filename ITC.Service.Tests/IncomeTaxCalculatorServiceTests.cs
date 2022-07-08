using ITC.Service.Interfaces;
using ITC.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace ITC.Service.Tests
{
    [TestClass]
    public class IncomeTaxCalculatorServiceTests
    {
        private IIncomeTaxCalculatorService _incomeTaxCalculatorService;

        public IncomeTaxCalculatorServiceTests()
        {
            _incomeTaxCalculatorService = new IncomeTaxCalculatorService();
        }

        [TestMethod]
        public void GetIncomeTaxFor1k()
        {

            //Arrange Test Data
            int income = 1000;
            int expectedResult = 0;

            //Act
            int actualResult = _incomeTaxCalculatorService.GetIncomeTax(income);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void GetIncomeTaxFor10k()
        {

            //Arrange Test Data
            int income = 10000;
            int expectedResult = 1000;

            //Act
            int actualResult = _incomeTaxCalculatorService.GetIncomeTax(income);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void GetIncomeTaxFor40k()
        {

            //Arrange Test Data
            int income = 40000;
            int expectedResult = 11000;

            //Act
            int actualResult = _incomeTaxCalculatorService.GetIncomeTax(income);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);

        }
    }
}