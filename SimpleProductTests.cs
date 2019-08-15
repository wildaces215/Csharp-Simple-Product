using NUnit.Framework;
namespace SimpleProduct
{
    [TestFixture]
    public class SimpleProductTest
    {
        Product testProductOne = new Product(45, (float)34.99, 1);
        Product testProductTwo = new Product(68, (float)39.99, 2);
        Product testProductThree = new Product(123, (float)99.99, 3);

        //Test for get Functions
        [Test]
        public void _getPrice() {
            Assert.AreEqual((float)34.99, testProductOne.getPrice());
            Assert.AreEqual((float)39.99, testProductTwo.getPrice());
            Assert.AreEqual((float)99.99, testProductThree.getPrice());

        }
        [Test]
        public void _getQuantity()
        {
            Assert.AreEqual(45,testProductOne.getQuantity());
            Assert.AreEqual(68,testProductTwo.getQuantity());
            Assert.AreEqual(123,testProductThree.getQuantity());
        }
        [Test]
        public void _getId()
        {
            Assert.AreEqual(1, testProductOne.getId());
            Assert.AreEqual(2,testProductTwo.getId());
            Assert.AreEqual(3, testProductThree.getId());
        }
    }
}

