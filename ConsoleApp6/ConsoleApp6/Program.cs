using System;
class Program
{
    static void Multiple(double x, double y)
    {
        if (x == 0 | y == 0)
            Console.WriteLine("Result: 0");
        else Console.WriteLine("Result: " + x / (1 / y));
    }


    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        Multiple(x, y);

    }
}