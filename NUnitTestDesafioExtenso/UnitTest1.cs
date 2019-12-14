using NUnit.Framework;
using CERTIDesafio;
using System;

namespace NUnitTestDesafioExtenso
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            string str = "";
            for (int i = -99999; i <= 99999; i++)
            {
                Numero num = new Numero(i);
                str += i.ToString() + ": " + num.Extenso + "\n";
            }

            Console.WriteLine(str);
            Assert.Pass();
            return;     
        }
    }
}