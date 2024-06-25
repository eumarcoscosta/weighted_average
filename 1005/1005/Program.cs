using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira a base do retangulo = ");
            double Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a altura do retangulo = ");
            double altura = double.Parse(Console.ReadLine());

            double Area = Base * altura;
            double Perimetro = 2 * (Base + altura);
            double Diagonal = Math.Sqrt(Math.Pow(Base, 2.0) + Math.Pow(altura, 2.0));

            Console.WriteLine("AREA = " + Area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + Perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + Diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
