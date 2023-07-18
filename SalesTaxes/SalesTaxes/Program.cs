using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    
    public static void Main(string[] args)
    {
       List<ProductLine> items = new List<ProductLine>();
       
        Cart cart = new Cart();
       
        const double BOOK_PRICE = 12.49;
        const double MUSIC_CD_PRICE = 14.99;
        const double CHOCOLATE_BAR_PRICE = 0.85;
        const double PACKET_OF_HEADACHE_PILLS_PRICE = 9.75;
        const double BOTTLE_OF_PERFUME_PRICE = 18.99;
        const double IMPORTED_BOX_OF_CHOCOLATES_PRICE = 11.25;
        const double IMPORTED_BOTTLE_OF_PERFUME_PRICE = 27.99;

        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the DealerOn Shop!\nPlease Select by the # to Add to Your Cart");
            Console.WriteLine("\n");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Music CD");
            Console.WriteLine("3. Chocolate Bar");
            Console.WriteLine("4. Packet of Headache Pills");
            Console.WriteLine("5. Bottle of Perfume");
            Console.WriteLine("6. Imported Box of Chocolates");
            Console.WriteLine("7. Imported Bottle of Perfume");
            Console.WriteLine("8. CHECKOUT");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.Clear();
                    Cart.AddItemToCart(items, BOOK_PRICE, "Book");
                    
                    break;
                case "2":
                    Console.Clear();
                    Cart.AddItemToCart(items, MUSIC_CD_PRICE, "Music CD");
                    break;
                case "3":
                    Console.Clear();
                    Cart.AddItemToCart(items, CHOCOLATE_BAR_PRICE, "Chocolate Bar");
                    break;
                case "4":
                    Console.Clear();
                    Cart.AddItemToCart(items, PACKET_OF_HEADACHE_PILLS_PRICE, "Packet of Headache Pills");
                    break;
                case "5":
                    Console.Clear();
                    Cart.AddItemToCart(items, BOTTLE_OF_PERFUME_PRICE, "Bottle of Perfume");
                    break;
                case "6":
                    Console.Clear();
                    Cart.AddItemToCart(items, IMPORTED_BOX_OF_CHOCOLATES_PRICE, "Imported Box of Chocolates");
                    break;
                case "7":
                    Console.Clear();
                    Cart.AddItemToCart(items, IMPORTED_BOTTLE_OF_PERFUME_PRICE, "Imported Bottle of Perfume");
                    break;
                case "8":
                    Console.Clear();
                    Console.WriteLine("\tReceipt");
                    Console.WriteLine("\n");
                    Cart.PrintReceipt(items);
                    double totalTax = TaxHelper.TotalTax(items);
                    double total = Cart.TotalCosts(items);
                    Console.WriteLine("Sales Taxes: " + totalTax.ToString("0.00"));
                    Console.WriteLine("Total: " + total.ToString("0.00"));
                    Console.ReadKey();
                    isRunning = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please Type in a Number From the Provided Menu.");
                    Console.WriteLine("Press Any Key to Go Back to the Menu.");
                    Console.ReadKey();
                    break;

            }
        }
    }
}