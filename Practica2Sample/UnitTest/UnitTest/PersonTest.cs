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
        public void TestBuyaCarWithPriceNegative()
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual(false, source.BuyCar(-100));
        }
        [Test]
        public void TestBuyaCarWithPricePositive()
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual(true, source.BuyCar(5000));
        }
        [Test]
        public void TestBuyaCarWithSamePriceThatCash()
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual(true, source.BuyCar(100000));
        }

        [Test]
        public void TestBuyaCarWithPriceCEro()
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual(true, source.BuyCar(0));
        }

        [Test]
        public void TestPriceMajorToCash()
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual(false, source.BuyCar(150000));
        }

        [Test]
        public void Testdontbyacar()
        {
            Person source = new Person("PEDRO", "MIGUEL", 20);
            Assert.AreEqual(false, source.BuyCar(-150000));
        }
    }
}
