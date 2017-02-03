using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class LaskuTests
    {
        [TestMethod()]
        public void ReadyTest()
        {
            Lasku lasku = new Lasku();
            float expected = (0.75f * 3) + (0.90f * 2) + 3.95f +(1.20f*4);

            lasku.Tuotteet.Add(new Product("Maito", 0.75f), 3);
            lasku.Tuotteet.Add(new Product("Piimä", 0.90f), 2);
            lasku.Tuotteet.Add(new Product("Kahvi", 3.95f), 1);
            lasku.Tuotteet.Add(new Product("Saarioisten jauhelija pizza", 1.20f), 4);
            lasku.Ready();

            float actual = lasku.Kokonaishinta;
            Assert.AreEqual(expected, actual);
        }
    }
}