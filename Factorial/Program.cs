using System;

namespace Factorial
{
    class Program
    {

        static int Factorial(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }

        static void Main(string[] args)
        {
            int ans = Factorial(5);
        }
    }
}
