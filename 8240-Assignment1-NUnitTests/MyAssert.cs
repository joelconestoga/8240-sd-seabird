using NUnit.Framework;
using System;

namespace _8240_Assignment1_NUnitTests
{
    /// <summary>
    /// Class to hold custom implementations of asserts
    /// </summary>
    public class MyAssert
    {
        /// <summary>
        /// Custom implementation of an assert to catch exceptions
        /// </summary>
        /// <typeparam name="TException">
        /// Generic type that allows the assert to evaluate
        /// any type of exception</typeparam>
        /// <param name="action">
        /// Method to be executed for triggering the exception
        /// </param>
        /// <param name="message">Message expected to be thrown</param>
        /// <returns></returns>
        public static TException AssertThrows<TException>(Action action, string message)
            where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException expectedException)
            {
                Assert.AreEqual(message, expectedException.Message);
                return expectedException;
            }
            catch (Exception unexpectedException)
            {
                Assert.Fail(String.Format("Unexpected exception was thrown: {0}",
                    unexpectedException.GetType()));
            }

            Assert.Fail("Expected exception was not thrown.");

            return null;
        }
    }
}