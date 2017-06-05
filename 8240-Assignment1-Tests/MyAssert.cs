using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _8240_Assignment1_Tests
{
    public class MyAssert
    {
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