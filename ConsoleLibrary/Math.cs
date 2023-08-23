using System.Runtime.InteropServices.Marshalling;

namespace ConsoleLibrary
{
    public class Math
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }
        public static int Div(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot Divide by 0!");
                return 0;
            }
        }
        public static double Inverse(double x)
        {
            return 1 / x;
        }
        public static int Cubed(int x)
        {
            return x * x * x;
        }
        public static double Power(int x, int y)
        {
            double ans = x;
            for (int i = 1; i < y - 1; i++)
            {
                ans *= ans;
            }
            return ans;
        }
        public static int Mod(int x, int y)
        {
            int ans = x / y;
            return ans;
        }
    }
}