namespace InchesToCentimeter
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double centimeter = double.Parse(Console.ReadLine());
            double inch = centimeter * 2.54;
            Console.WriteLine(inch);
        }
    }
}
