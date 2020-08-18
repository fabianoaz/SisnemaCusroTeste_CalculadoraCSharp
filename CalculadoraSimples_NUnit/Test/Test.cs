using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CalculadoraSimples_NUnit.App;

namespace CalculadoraSimples_NUnit.Test
{
    [TestFixture]
    public class Test_Calc
    {
        
        [TestCase(TestName = "Soma de dois valores positivos, retorno um valor positivo")]
        public static void SomaValoresPositivos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(15, calc.Soma(10,5));
        }
        [TestCase(TestName = "Soma de dois valores negativos, retorno um valor negativo")]
        public static void SomaValoresNegativos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(-15, calc.Soma(-10, -5));
        }

        [TestCase(TestName = "Subtração de dois valores positivos, retorno um valor positivo")]
        public static void SubtraiValoresPositivos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(5, calc.Subtrai(10,5));
        }

        [TestCase(TestName = "Subtração de dois valores negativos, retorno um valor negativo")]
        public static void SubtraiValoresNegativos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(-5, calc.Subtrai(-10, -5));
        }

        [TestCase(TestName = "Divisão de dois valores positivos, retorno um valor positivo")]
        public static void DivideValoresPositivos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(2, calc.Divide(10,5));
        }
        [TestCase(TestName = "Divisão de dois valores negativos, retorno um valor positivo")]
        public static void DivideValoresNegativos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(2, calc.Divide(-10, -5));
        }

        [TestCase(TestName = "Divisão de um valor positivo por ZERO, retorno mensagem de alerta")]
        public static void DivideValorPositivoPorZero()
        {
            Calculadora calc = new Calculadora();

            try
            {
                Assert.AreEqual(2, calc.Divide(10, 0));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestCase(TestName = "Divisão de um valor negativo por ZERO, retorno mensagem de alerta")]
        public static void DivideValorNegativoPorZero()
        {
            Calculadora calc = new Calculadora();

            try
            {
                Assert.AreEqual(2, calc.Divide(-10, 0));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestCase(TestName = "Multiplicação de dois valores positivos, retorno um valor positivo")]
        public static void MultiplicaValoresPositivos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(50, calc.Multiplica(10,5));
        }
        [TestCase(TestName = "Multiplicação de dois valores negativos, retorno um valor positivo")]
        public static void MultiplicaValoresNegativos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(50, calc.Multiplica(-10, -5));
        }

    }
}
