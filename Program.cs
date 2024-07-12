using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Modules;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First Product
            Product product1 = new Product();
            SetDetails(product1,1,"Book",50,10 );

            //Second Product
            Product product2 = new Product();
            SetDetails(product2, 2, "School bag", 300, 15);

            //To display First Product Detail
            ShowProductDetails(product1);

            //To Separate the products
            Console.WriteLine("=================================");

            //To display Second Product Detail
            ShowProductDetails(product2);


        }
        //Method to display Details of product
        static void ShowProductDetails(Product product)
        {
            Console.WriteLine("Product Id : " + product.GetId());
            Console.WriteLine("Product Name : "+product.GetName());
            Console.WriteLine("Product Actual Price : "+product.GetPrice());
            Console.WriteLine("Discount Percentage on product : "+product.GetDiscout()+"%");
            Console.WriteLine("Product final price after discount : "+product.FinalPriceAfterDiscount());

        }
        static void SetDetails(Product product, int id, string name, int price, int discount)
        {
            product.SetId(id);
            product.SetName(name);
            product.SetPrice(price);
            product.SetDiscount(discount);
        }

    }
}
