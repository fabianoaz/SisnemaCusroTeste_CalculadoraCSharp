using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSimples_NUnit.App
{
    public class Calculadora
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }
        public int Subtrai(int a, int b)
        {
            return a - b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public int Multiplica(int a, int b)
        {
            return a * b;
        }
    }
}
