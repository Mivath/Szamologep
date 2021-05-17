using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Szamologep.Lib;

namespace Szamologep.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Alapertek0()
        {
            var gep = new Gep();
            Assert.AreEqual("0", gep.Ertek);
        }
        [TestMethod]
        public void Be_Szamjegyek()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_1);
            Assert.AreEqual("1", gep.Ertek);

            gep.Be(Szamjegyek.Szj_5);
            Assert.AreEqual("15", gep.Ertek);
        }
        [TestMethod]
        public void Be_Unaris_EgyPerX()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_2);

            gep.Be(Unaris.EgyPerX);
            Assert.AreEqual("0.5", gep.Ertek);

            gep.Be(Szamjegyek.Szj_1);
            Assert.AreEqual("1", gep.Ertek);
        }
        [TestMethod]
        public void Be_Unaris_XNegyzet()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_2);

            gep.Be(Unaris.XNegyzet);
            Assert.AreEqual("4", gep.Ertek);

            gep.Be(Szamjegyek.Szj_1);
            Assert.AreEqual("1", gep.Ertek);
        }
        [TestMethod]
        public void Be_Unaris_Negacio()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_2);

            gep.Be(Unaris.Negacio);
            Assert.AreEqual("-2", gep.Ertek);

            gep.Be(Szamjegyek.Szj_1);
            Assert.AreEqual("1", gep.Ertek);
        }
        [TestMethod]
        public void Be_Unaris_GyokX()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_4);

            gep.Be(Unaris.GyokX);
            Assert.AreEqual("2", gep.Ertek);

            gep.Be(Szamjegyek.Szj_1);
            Assert.AreEqual("1", gep.Ertek);
        }
        [TestMethod]
        public void Be_Unaris_EgyPer0()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_0);

            gep.Be(Unaris.EgyPerX);
            Assert.IsTrue(Double.IsInfinity(gep.ValosErtek));
        }
        [TestMethod]
        public void Be_Unaris_GyokNegativ()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_4);
            gep.Be(Unaris.Negacio);
            gep.Be(Unaris.GyokX);
            Assert.IsTrue(Double.IsNaN(gep.ValosErtek));
        }
        [TestMethod]
        public void Tizedes()
        {
            var gep = new Gep();
            gep.Tizedes();
            Assert.AreEqual("0.", gep.Ertek);

            gep.Be(Szamjegyek.Szj_1);

            Assert.AreEqual("0.1", gep.Ertek);
            gep.Be(Szamjegyek.Szj_5);
            Assert.AreEqual("0.15", gep.Ertek);

        }
        [TestMethod]
        public void DuplaTizedes()
        {
            var gep = new Gep();
            gep.Tizedes();
            gep.Be(Szamjegyek.Szj_1);
            gep.Tizedes();
            Assert.AreEqual("0.1", gep.Ertek);
            gep.Be(Szamjegyek.Szj_5);
            Assert.AreEqual("0.15", gep.Ertek);

        }
        [TestMethod]
        public void Vissza()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_1);
            gep.Be(Szamjegyek.Szj_5);
            gep.Vissza();
            Assert.AreEqual("1", gep.Ertek);
        }
        [TestMethod]
        public void Vissza0()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_1);
            gep.Vissza();
            Assert.AreEqual("0", gep.Ertek);
        }
        [TestMethod]
        public void Vissza_Eredmeny_Utan()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_2);
            gep.Be(Unaris.EgyPerX);
            gep.Vissza();
            Assert.AreEqual("0.5", gep.Ertek);
        }
        //[TestMethod]
        //public void Plusz()
        //{
        //    var gep = new Gep();
        //    gep.Be(Szamjegyek.Szj_1);
        //    gep.Be(Binaris.Osszead);

        //    Assert.AreEqual("0", gep.Ertek);
        //}
        [TestMethod]
        public void FullTorles()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_1);
            gep.Be(Szamjegyek.Szj_1);
            gep.Be(Szamjegyek.Szj_1);
            gep.CE();
            Assert.AreEqual("0", gep.Ertek);
        }
        [TestMethod]
        public void FullTorlesTizedes()
        {
            var gep = new Gep();
            gep.Tizedes();
            gep.Be(Szamjegyek.Szj_1);
            gep.CE();
            gep.Be(Szamjegyek.Szj_3);
            Assert.AreEqual("3", gep.Ertek);
        }
        [TestMethod]
        public void FullTorlesUtanSzamjegyekBeirasa()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_1);
            gep.Be(Unaris.EgyPerX); //ettol eredmeny lesz
            gep.CE();
            gep.Be(Szamjegyek.Szj_2);
            gep.Be(Szamjegyek.Szj_3);
            Assert.AreEqual("23", gep.Ertek);
        }
    }
}
