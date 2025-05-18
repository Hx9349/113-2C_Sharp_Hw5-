namespace Chap10Test3_3
{
    interface IPrice
    {
        double GetPrice();
    }

    class Car : IPrice
    {
        public double Price;
        public string Name;
        public string GetName() => Name = "557Y";
        public double GetPrice() => Price = 12345678;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bb = new Car();
            Console.WriteLine("車子型號："+ bb.GetName().ToString());
            Console .WriteLine("價格："+ bb.GetPrice());
        }
    }
}