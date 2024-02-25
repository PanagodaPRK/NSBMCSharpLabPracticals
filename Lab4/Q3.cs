//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab4
//{
//    public class Product
//    {
//        private int productId;
//        private string productName;
//        private double price;
//        private int quantityInStock;

//        public Product(int id, string name, double Price, int quantity)
//        {
//            productId = id;
//            productName = name;
//            price = Price;
//            quantityInStock = quantity;
//        }

//        public void AddProduct(int quantityToAdd)
//        {
//            quantityInStock += quantityToAdd;
//            Console.WriteLine("Product/s added to stock.");
//        }

//        public void BuyProduct(int quantityToBuy)
//        {
//            if (quantityToBuy <= quantityInStock)
//            {
//                quantityInStock -= quantityToBuy;
//                Console.WriteLine("Product/s sold.");
//            }
//            else
//            {
//                Console.WriteLine("Not enough stock.");
//            }
//        }

//        public void DisplayProductDetails()
//        {
//            Console.WriteLine("Product Name: " + productName);
//            Console.WriteLine("Price: " + price);
//            Console.WriteLine("Quantity in Stock: " + quantityInStock);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Product laptop = new Product(101, "Laptop", 800, 10);
//            laptop.DisplayProductDetails();

//            //laptop.productId = 102;

//            //Comment:
//            //due to the protection level of "productID" it is not possible to change values from here and would result in an error.

//            Console.ReadLine();
//        }
//    }
//}