using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{

    [TestFixture]
     class DiscountTest
    {
        [Test]
        public void TestExceptionwithCero1()
        {
            Discount discountPrice = new Discount();
            
            var ex = Assert.Throws<Exception>(() => discountPrice.calculateDiscount(0));
            Assert.That(ex.Message, Is.EqualTo("Sales Amount should not be 'Zero/Negative'"));
           
        }


       [Test]
       [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestExceptionwithCero()
        {
            Discount discountPrice = new Discount();
            discountPrice.calculateDiscount(0);
            Assert.Fail("ArgumentException");
      }





        [Test]
        public void TestDiscountPriceFivePercent()
        {
            Discount discountPrice = new Discount();
            double result = discountPrice.calculateDiscount(1900);
            Assert.AreEqual(1805, result);
        }
        [Test]
        public void TestDiscountPriceTenPercent()
        {
            Discount discountPrice = new Discount();
            double result = discountPrice.calculateDiscount(2000);
            Assert.AreEqual(1800, result);
        }
        [Test]
        public void TestDiscountPricefiftyPercent()
        {
            Discount discountPrice = new Discount();
            double result = discountPrice.calculateDiscount(5500);
            Assert.AreEqual(2750, result);
        }
        [Test]
        public void TestNoDiscount()
        {
            Discount discountPrice = new Discount();
            double result = discountPrice.calculateDiscount(500);
            Assert.AreEqual(500, result);
        }
    }
}
