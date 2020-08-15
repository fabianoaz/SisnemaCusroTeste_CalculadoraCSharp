using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CalculadoraSimples_NUnit.App;

namespace CalculadoraSimples_NUnit.Test
{
    public class Test_Calc
    {
        

        [Test]
        public static void SomaValoresPositivos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(15, calc.Soma(10,5));
        }
        [Test]
        public static void SomaValoresNegativos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(-15, calc.Soma(-10, -5));
        }

        [Test]
        public static void SubtraiValoresPositivos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(5, calc.Subtrai(10,5));
        }
        [Test]
        public static void SubtraiValoresNegativos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(-5, calc.Subtrai(-10, -5));
        }

        [Test]
        public static void DivideValoresPositivos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(2, calc.Divide(10,5));
        }
        [Test]
        public static void DivideValoresNegativos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(2, calc.Divide(-10, -5));
        }

        [Test]
        public static void MultiplicaValoresPositivos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(50, calc.Multiplica(10,5));
        }
        [Test]
        public static void MultiplicaValoresNegativos()
        {
            Calculadora calc = new Calculadora();
            Assert.AreEqual(50, calc.Multiplica(-10, -5));
        }

    }
}
