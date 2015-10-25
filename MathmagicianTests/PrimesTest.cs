using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class PrimesTest
    {
        [TestMethod]
        public void PrimeEnsuerICanCreateClassInstance()
        {
            PrimeNumbers primes = new PrimeNumbers();
            Assert.IsNotNull(primes);
        }

        [TestMethod]
        public void FibonacciShouldPrintFirstNumber()
        {
            PrimeNumbers primes = new PrimeNumbers();
            int expected = 2;
            int actual = primes.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintNextNumber()
        {
            PrimeNumbers primes = new PrimeNumbers();
            int input = 2;
            int expected = 3;
            int actual = primes.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimePrintOfSequenceOfNumbers()
        {
            PrimeNumbers primes = new PrimeNumbers();
            int length = 8;
            string expected = "2 3 5 7 11 13 17 19";
            string actual = primes.ToString(primes.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintAVariableSequenceOfNumbers()
        {
            PrimeNumbers primes = new PrimeNumbers();
            int input = 8;
            int[] expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, };
            int[] actual = primes.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
