using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Este es un programa que convierte los grados Fahrenheit en grados Celsius");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Ingrese los grados fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) / 1.8;
            Console.WriteLine("La temperatura equivalente de grados Fahrenheit en Celsius es: {0} grados", celsius.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
