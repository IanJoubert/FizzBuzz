

namespace FizzBuzz
{
    public static class FizzBuzz

    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public static string GetFizzBuzzValue(int v)
        {
            if (v == 0)
            {
                return "";
            }

            if (v % 3 == 0 && v % 5 == 0)
            {
                return Fizz + Buzz;
            }

            if (v % 3 == 0)
            {
                return Fizz;
            }

            if (v % 5 == 0)
            {
                return Buzz;
            }

            return "";
        }
    }
}