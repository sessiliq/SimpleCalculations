namespace YardGreening
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double yard = double.Parse(Console.ReadLine());
            double price = yard * 7.61;
            double discount = 0.18 * price;
            double fprice = price - discount;
            Console.WriteLine("The final price is: {0:f2} lv.", fprice);
            Console.WriteLine("The discount is: {0:f2} lv.", discount);

        }
    }
}
