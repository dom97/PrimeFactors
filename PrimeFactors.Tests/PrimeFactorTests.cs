using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeFactors.Tests
{
    [TestClass]
    public class PrimeFactorTests
    {
        [TestMethod]
        public void GenerateOneReturnsEmptyList()
        {
            var primeFactors = PrimeFactors.Generate(1);
            Assert.IsFalse(primeFactors.Any());
        }

        [TestMethod]
        public void GenerateTwoReturnsTwo()
        {
            var expected = new List<Int32>() { 2 };
            CollectionAssert.AreEqual(expected, PrimeFactors.Generate(2));
        }

        [TestMethod]
        public void GenerateThreeReturnsThree()
        {
            var expected = new List<Int32>() { 3 };
            CollectionAssert.AreEqual(expected, PrimeFactors.Generate(3));
        }

        [TestMethod]
        public void GenerateFourReturnsTwoTwo()
        {
            var expected = new List<Int32>() { 2, 2 };
            CollectionAssert.AreEqual(expected, PrimeFactors.Generate(4));
        }

        [TestMethod]
        public void GenerateSixReturnsTwoThree()
        {
            var expected = new List<Int32>() { 2, 3 };
            CollectionAssert.AreEqual(expected, PrimeFactors.Generate(6));
        }

        [TestMethod]
        public void GenerateEightReturnsTwoTwoTwo()
        {
            var expected = new List<Int32>() { 2, 2, 2 };
            CollectionAssert.AreEqual(expected, PrimeFactors.Generate(8));
        }

        [TestMethod]
        public void GenerateNineReturnsThreeThree()
        {
            var expected = new List<Int32>() { 3, 3 };
            CollectionAssert.AreEqual(expected, PrimeFactors.Generate(9));
        }
    }
}
