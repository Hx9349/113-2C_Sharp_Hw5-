using System;

namespace Chap12Test3_3
{
    internal class Program
    {
        public static void FeetToInches(double inches)
        {
            double feet = inches / 12;
            Console.WriteLine($"{inches} 英吋 = {feet} 英尺");
        }
        public static void YardsToInches(double inches)
        {
            double yards = inches / 36;
            Console.WriteLine($"{inches} 英吋 = {yards} 英碼");
        }

        public delegate void ConvertDelegate(double inches);

        static void Main(string[] args)
        {
            Console.Write("請輸入英吋：");
            double inches = double.Parse(Console.ReadLine());

            ConvertDelegate[] converters = {
                FeetToInches,
                YardsToInches
            };

            foreach (var converter in converters)
            {
                converter(inches);
            }
        }
    }
}