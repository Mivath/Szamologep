using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Szamologep.Lib;

namespace Szamologep.Tests
{
    [TestClass]
    public class Tesztek2
    {
        [TestMethod]
        public void OsszeadasIrasa1()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_2);
            gep.Be(Binaris.Osszead);
            Assert.AreEqual("2", gep.Ertek);
        }
        [TestMethod]
        public void OsszeadasIrasa2()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_2);
            gep.Be(Binaris.Osszead);
            gep.Be(Szamjegyek.Szj_3);
            Assert.AreEqual("3", gep.Ertek);
        }
        [TestMethod]
        public void Osszeadas()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_2);
            gep.Be(Binaris.Osszead);
            gep.Be(Szamjegyek.Szj_3);
            gep.Egyenlo();
            Assert.AreEqual("5", gep.Ertek);
        }
        [TestMethod]
        public void Kivonas()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_2);
            gep.Be(Binaris.Kivon);
            gep.Be(Szamjegyek.Szj_3);
            gep.Egyenlo();
            Assert.AreEqual("-1", gep.Ertek);
        }
        [TestMethod]
        public void Szorzas()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_2);
            gep.Be(Binaris.Szoroz);
            gep.Be(Szamjegyek.Szj_3);
            gep.Egyenlo();
            Assert.AreEqual("6", gep.Ertek);
        }
        [TestMethod]
        public void Osztas()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_6);
            gep.Be(Binaris.Oszt);
            gep.Be(Szamjegyek.Szj_3);
            gep.Egyenlo();
            Assert.AreEqual("2", gep.Ertek);
        }
        [TestMethod]
        public void OsztasNullaval()
        {
            var gep = new Gep();
            gep.Be(Szamjegyek.Szj_6);
            gep.Be(Binaris.Oszt);
            gep.Be(Szamjegyek.Szj_0);
            gep.Egyenlo();
            Assert.IsTrue(Double.IsInfinity(gep.ValosErtek));
        }
    }
}
