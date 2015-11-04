using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    class PersonTest
    {
        [Test]
        public void TestCreateDefaultPersonIsNotNull() 
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.IsNotNull(source);
        }

        [Test]
        public void TestGetFullName()
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual("PEDRO MIGUEL", source.FullName);
        }

        [Test]
        public void TestGetAge()
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual(20, source.Age);
        }

        [Test]
        public void TestCashBalance()
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual(100000, source.CashBalance);
        }

        [Test]
        public void Testbuyacar()
        {
            //lA FUNCIÓN SUMA, EN VEZ DE RESTAR
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual(true, source.BuyCar(-100));
        }

        [Test]
        public void Testdontbyacar()
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual(false, source.BuyCar(-100001));
        }
    }
}
