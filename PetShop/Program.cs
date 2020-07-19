namespace PetShop
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int dogs2 = int.Parse(Console.ReadLine());
            double price = dogs * 2.50;
            double price2 = dogs2 * 4;
            Console.WriteLine("{0:f2} lv.", price + price2);
        }
    }
}
