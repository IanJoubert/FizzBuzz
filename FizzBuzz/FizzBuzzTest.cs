using NUnit.Framework;

namespace FizzBuzz
{
    public class FizzBuzzTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0, ExpectedResult = "")]
        [TestCase(2, ExpectedResult = "")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        public string TestFizzBuzz(int input)
        {
            return FizzBuzz.GetFizzBuzzValue(input);
        }
    }
}