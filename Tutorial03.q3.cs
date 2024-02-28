using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tute0303
{
        public class Product
        {
            
            private int productId;
            private string productName;
            private double price;
            private int quantityInStock;

            
            public Product(int productId, string productName, double price, int quantityInStock)
            {
                this.productId = productId;
                this.productName = productName;
                this.price = price;
                this.quantityInStock = quantityInStock;
            }

            
            public void DisplayProductDetails()
            {
                Console.WriteLine($"Product Name: {productName}");
                Console.WriteLine($"Price: ${price}");
                Console.WriteLine($"Quantity in Stock: {quantityInStock}");
            }

            
            public void AddProduct(int quantityToAdd)
            {
                if (quantityToAdd > 0)
                {
                    quantityInStock += quantityToAdd;
                    Console.WriteLine($"{quantityToAdd} {productName}(s) added to the stock.");
                }
                else
                {
                    Console.WriteLine("Invalid quantity to add. Quantity must be greater than 0.");
                }
            }

            
            public void BuyProduct(int quantityToBuy)
            {
                if (quantityToBuy > 0 && quantityToBuy <= quantityInStock)
                {
                    quantityInStock -= quantityToBuy;
                    Console.WriteLine($"{quantityToBuy} {productName}(s) bought.");
                }
                else
                {
                    Console.WriteLine("Invalid quantity to buy. Either quantity is less than or equal to 0 or exceeds the available stock.");
                }
            }
        }

        class Program
        {
            static void Main()
            {
               
                Product laptop = new Product(101, "Laptop", 800, 10);

                // Access and display product details
                laptop.DisplayProductDetails();

                // Attempt to modify the product's ID from external code
                // This will result in a compilation error because productId is private
                // laptop.productId = 102; // Uncommenting this line will result in an error

                // Add 5 laptops to the stock
                laptop.AddProduct(5);

                // Display updated details
                laptop.DisplayProductDetails();

                // Buy 3 laptops from the stock
                laptop.BuyProduct(3);

                // Display updated details after buying
                laptop.DisplayProductDetails();

                Console.ReadLine(); // To keep the console window open
            }
        }
    }

