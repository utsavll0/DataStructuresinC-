using System;

namespace Fibonnaci
{
    class Program
    {
        static int Fibonnaci(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            if(num == 0)
            {
                return 0;
            }
            return Fibonnaci(num - 1) + Fibonnaci(num - 2);
        }
        static void Main(string[] args)
        {
            int ans = Fibonnaci(10);
        }
    }
}
