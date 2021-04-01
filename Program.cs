using System;

namespace heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;
            double f, triangle, sp;
            Console.WriteLine("Digite os lados do triângulo desejado.");
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.Write("Digite um valor para o lado A ==> ");
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            a=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.Write("Digite um valor para o lado B ==> ");
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            b=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.Write("Digite um valor para o lado C ==> ");
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            c=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            f=(a+b+c)/2;
            triangle= Math.Sqrt(f*(f-a)*(f-b)*(f-c));
            sp=(a+b+c)/2;
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.WriteLine("Área = "+triangle);
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Semiperímetro = "+sp);
            Console.ResetColor();
            Console.Beep();
        }
    }
}
