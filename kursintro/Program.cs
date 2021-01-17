using System;

namespace kursintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "I Phone X";
            product1.color = "Black";
            product1.productPrice = 8000;
            product1.discountRate = 15;

            Product product2 = new Product();
            product2.productName = "Samsung S7 Edge";
            product2.color = "Silver";
            product2.productPrice = 2000;
            product2.discountRate = 10;

            Product product3 = new Product();
            product3.productName = "Oppo Reno4 Pro";
            product3.color = "Blue";
            product3.productPrice = 7500;
            product3.discountRate = 20;

            Product[] products = new Product[] { product1, product2, product3 };
            Console.WriteLine("----Foreach----");
            foreach (var product in products)
            {
                Console.WriteLine("Ürün Detayları\n Ürün Adı : " + product.productName + "\n Renk : " + product.color + "\n Fiyatı : " + product.productPrice + "\n İndirim Oranı : " + product.discountRate + "\n İndirimli Fiyatı : " + product.discountedPrice);
            }

            Console.WriteLine("----For Döngüsü----");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Adı : " + products[i].productName + "\nRenk : " + products[i].color + "\nFiyat : " + products[i].productPrice + "\nİndirim Oranı : " + products[i].discountRate + "\nİndirimli Fiyat : " + products[i].discountedPrice);
            }
            Console.WriteLine("---While Döngüsü---");
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine("Ürün Adı:" + products[j].productName + "\nRenk : " + products[j].color + "\nFiyat : " + products[j].productPrice + "\nİndirim Oranı : " + products[j].discountRate + "\nİndirimli Fiyat : " + products[j].discountedPrice);
                j++;
            }
        }
        class Product
        {
            public int id { get; set; }
            public string productName { get; set; }
            public string color { get; set; }
            public double productPrice { get; set; }
            public double discountRate { get; set; }
            public double discountedPrice
            {
                get
                {
                    return productPrice - (productPrice * discountRate / 100);
                }
            }
        }
    }
}


