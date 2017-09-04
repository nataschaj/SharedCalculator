using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        //[TestMethod()]
        //public void UdskrivResultatTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void BestemLommeregnerTest()
        {

            double resultat;
            //Arrange
            var lommeregner = new Calculator();

            //Act
            resultat = lommeregner.BestemLommeregner(4,4,"+");

            //Assert
            Assert.AreEqual(8, resultat);
        }
    }
    
}