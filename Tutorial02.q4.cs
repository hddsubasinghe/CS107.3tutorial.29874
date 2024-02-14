using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial02q4
{
    
    
        class Product
        {
            
            public string ProductName { get; set; }
            public double Price { get; set; }

            public Product(string productName, double price)
            {
                ProductName = productName;
                Price = price;
            }

            
            public void DisplayProductDetails()
            {
                Console.WriteLine($"Product: {ProductName}");
                Console.WriteLine($"Price: ${Price:F2}\n");
            }
        }

        class Program
        {
            static void Main()
            {
                
                Product product1 = new Product("Laptop", 899.99);
                Product product2 = new Product("Smartphone", 499.99);

               
                Console.WriteLine("Product Details:");
                product1.DisplayProductDetails();
                product2.DisplayProductDetails();
            }
        }
    }

