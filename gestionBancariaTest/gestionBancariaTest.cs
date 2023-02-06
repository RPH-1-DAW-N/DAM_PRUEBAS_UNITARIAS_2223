using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTest
    {
        [TestMethod]
        public void validarMetodoIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        public void validarMetodoIngreso2()
        {
            double saldoInicial = 1500;
            double ingreso = 1000;
            double saldoActual = 0;
            double saldoEsperado = 2500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        public void validarMetodoReintegro()
        {
            double cantidad = 500;
            double saldoActual = 1500;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoActual);
            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoIngresoNegativo()
        {
            double saldoInicial = 1000;
            double ingreso = -500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoReintegroCantNeg()
        {
            double cantidad = -500;
            double saldoActual = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoActual);
            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoReintegroSaldIns()
        {
            double cantidad = 500;
            double saldoActual = 400;

            gestionBancaria cuenta = new gestionBancaria(saldoActual);
            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();
        }
    }
}
