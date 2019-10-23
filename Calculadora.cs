using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Calculadora
{
    public class Calculadora
    {
        private double num1;
        private double num2;

        public Calculadora()
        {
            num1 = 0;
            num2 = 0;
        }
        public Calculadora(double nnum1, double nnum2)
        {
            nnum1 = num1;
            nnum2 = num2;
        }
        public void SetNum1(double nnum1)
        {
            num1 = nnum1;
        }
        public double GetNum1()
        {
            return num1;
        }
        public void SetNum2(double nnum2)
        {
            num2 = nnum2;
        }
        public double GetNum2()
        {
            return num2;
        }
        public double Suma()
        {
            return num1 + num2;
        }
        public double Resta()
        {
            return num1 - num2;
        }
        public double Multiplicacion()
        {
            return num1 * num2;
        }
        public double Division()
        {
            return num1 / num2;
        }
    }
}
