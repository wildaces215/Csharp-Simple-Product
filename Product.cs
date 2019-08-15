using System;
namespace SimpleProduct
{
    public class Product
    {
		public int q;
		public float pr;
		public int i;
        public Product(int quantity,float price, int id)
        {
			q = quantity;
			pr = price;
			i = id;

        }
        public int getQuantity()
        {
            return q;
        }
        public float getPrice()
        {
            return pr;
        }
        public int getId()
        {
            return i;
        }
        public float changePrice(float newPrice)
        {
            newPrice = pr;
            return pr;
        }
        public int quantity(int newQuality)
        {
            return q;
        }
    }
}
