using System;
namespace polymorphism
{
    public class Library
    {
        public Library()
        {
            products = new Product[0];
        }
        public Product[] products;

        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;

        }
        public int GetJournalCount()
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item is Journal)
                {
                    count++;
                }
                
            }
            return count;
        }
        public int GetBooksCount()
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item is Book)
                {
                    count++;
                }
            }
            return count;
        }
        



    }
}
