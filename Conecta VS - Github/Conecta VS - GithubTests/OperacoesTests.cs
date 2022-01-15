using Microsoft.VisualStudio.TestTools.UnitTesting;
using Conecta_VS___Github;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta_VS___Github.Tests
{
    [TestClass()]
    public class OperacoesTests
    {
        [TestMethod()]
        public void somaTest()
        {

            int a = 5;
            int b = 5;
            int esperado = 10;

            var operacoes = new Operacoes();

            var result = operacoes.soma(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void subtrairTest()
        {
            int a = 5;
            int b = 5;
            int esperado = 0;

            var operacoes = new Operacoes();

            var result = operacoes.subtrair(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void dividirTest()
        {

            int a = 5;
            int b = 5;
            int esperado = 1;

            var operacoes = new Operacoes();

            var result = operacoes.dividir(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void multiplicarTest()
        {

            int a = 5;
            int b = 5;
            int esperado = 25;

            var operacoes = new Operacoes();

            var result = operacoes.multiplicar(a, b);

            Assert.AreEqual(esperado, result);
        }
    }
}