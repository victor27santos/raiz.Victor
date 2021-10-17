using System;

namespace projeto_raiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracao de variaveis 
            double a, b, c, delta, x1, x2;

            //entrada de de dados
            Console.Write("digite o valor de A:");
            a = double.Parse(Console.ReadLine());

            Console.Write("digite o valor de B:");
            b = double.Parse(Console.ReadLine());

            Console.Write("digite o valor de C:");
            c = double.Parse(Console.ReadLine());

            //processamento

            delta = (Math.Pow(b, 2) - 4 * a * c);
            Console.WriteLine("O valor de delta é:" + delta);

            x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            x2 = (-b - Math.Sqrt(delta)) / 2 * a;

            if (delta > 0)
            {
                Console.WriteLine("Exisem 2 raizes reais diferentes. X1:" + x1 + "X2");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Exisem 2 raizes reais diferentes. X1:" + x1 + "X2");
            }
            else
            {
                Console.WriteLine("Não existem raizes reais");

            }


            Console.ReadKey();

        }
    }
}

