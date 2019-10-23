using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objeto con datos definidos por el usuario");
            Console.WriteLine("----------------------------");
            Calculadora miCalculadora = new Calculadora();
            Console.Write("Ingrese el primer numero: ");
            miCalculadora.SetNum1(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Ingrese el segundo numero: ");
            miCalculadora.SetNum2(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("----------------------------");
            Console.WriteLine("La suma es: " + miCalculadora.Suma());
            Console.WriteLine("La resta es: " + miCalculadora.Resta());
            Console.WriteLine("La multiplicacion es: " + miCalculadora.Multiplicacion());
            Console.WriteLine("La division es: " + miCalculadora.Division().ToString("0.00"));
            Console.WriteLine("----------------------------");
            Console.WriteLine("Objeto definido(7,3): ");
            Console.WriteLine("----------------------------");
            Calculadora miCalculadora2 = new Calculadora(7, 3);
            Console.WriteLine("La suma es: " + miCalculadora2.Suma());
            Console.WriteLine("La resta es: " + miCalculadora2.Resta());
            Console.WriteLine("La multiplicacion es: " + miCalculadora2.Multiplicacion());
            Console.WriteLine("La division es: " + miCalculadora2.Division().ToString("0.00"));
            Console.ReadKey();
        }
    }
}
