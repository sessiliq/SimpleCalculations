namespace Aquarium
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double capacity = lenght * height * widht;
            double liter = capacity * 0.001;
            double percent1 = percent * 0.01;
            double liter1 = liter * (1 - percent1);
            Console.WriteLine("{0:f3}",liter1);


        }
    }
}
