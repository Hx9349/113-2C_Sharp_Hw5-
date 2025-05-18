using System.Runtime.Intrinsics.X86;

namespace Chap11Test3_1
{
    internal class Program
    {
        public static int Cube(int x) => x * x * x;
        public static double Cube(double x) => x * x * x;
        public static int MinElement(int a, int b, int c) => Math.Min(a, Math.Min(b,c));
        public static int MinElement(int a, int b, int c, int d) => Math.Min(Math.Min(a,b) ,Math.Min(c, d));
        
        static void Main(string[] args)
        {
            Console.WriteLine($"5的立方(int):{Cube(5)}");
            Console.WriteLine($"5.0 的立方(double)：{Cube(5.0):F1}");
            Console.WriteLine($"\n三個數中之最小值(1, 2, 3)：{MinElement(1, 2, 3)}");
            Console.WriteLine($"四個數中之最小值(-1, -2, -3, -4)：{MinElement(-1, -2, -3, -4)}");
        }
    }
}
