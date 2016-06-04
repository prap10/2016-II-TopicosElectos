using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Calculadora.Test
{
    [TestClass]
    public class TestDeLasSumas
    {
        [TestMethod]
        public void unoMasCuatro()
        {
            Numero elPrimerOperando = new Numero("1", 10);
            Numero elSegundoOperando = new Numero("4", 10);

            Numero elResultadoEsperado = new Numero("5", 10);
            Numero elResultadoReal;

            var laReferencia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferencia.operar(elPrimerOperando, elSegundoOperando);

            Assert.AreEqual<Numero>(elResultadoReal, elResultadoEsperado);
        }
    }
}
