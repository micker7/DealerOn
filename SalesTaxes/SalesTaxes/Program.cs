using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    
    public static void Main(string[] args)
    {
        List<string> items = new List<string>();
        List<double> costs = new List<double>();



        Cart cart = new Cart();

        int numberOfBooks = 0;
        int numberOfMusicCDs = 0;
        int numberOfChocolateBars = 0;
        int numberOfPacketOfHeadachePills = 0;
        int numberOfBottlesOfPerfume = 0;
        int numberOfImportedBoxesOfChocolates = 0;
        int numberOfImportedBottlesOfPerfume = 0;

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
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to the DealerOn Shop!\nPlease Select by the # to Add to Your Cart");
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
                    
                    if (items.Contains("Book")) 
                    {
                        numberOfBooks++;
                    }
                    else
                    {
                        items.Add("Book");
                        numberOfBooks++;
                    }
                    costs.Add(BOOK_PRICE);
                    Console.WriteLine("You Added a Book to Your Shopping Cart");
                    Console.WriteLine("Press Enter to Go Back to the Menu.");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    if (items.Contains("Music CD"))
                    {
                        numberOfMusicCDs++;
                    }
                    else
                    {
                        items.Add("Music CD");
                        numberOfMusicCDs++;
                    }
                    
                    costs.Add(MUSIC_CD_PRICE);
                    Console.WriteLine("You Added a Music CD to Your Shopping Cart");
                    Console.WriteLine("Press Enter to Go Back to the Menu.");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    if (items.Contains("Chocolate Bar"))
                    {
                        numberOfChocolateBars++;
                    }
                    else
                    {
                        items.Add("Chocolate Bar");
                        numberOfChocolateBars++;
                    }
                    costs.Add(CHOCOLATE_BAR_PRICE);
                    Console.WriteLine("You Added a Chocolate Bar to Your Shopping Cart");
                    Console.WriteLine("Press Enter to Go Back to the Menu.");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    if (items.Contains("Packet of Headache Pills"))
                    {
                        numberOfPacketOfHeadachePills++;
                    }
                    else
                    {
                        items.Add("Packet of Headache Pills");
                        numberOfPacketOfHeadachePills++;
                    }
                    costs.Add(PACKET_OF_HEADACHE_PILLS_PRICE);
                    Console.WriteLine("You Added a Packet of Headache Pills to Your Shopping Cart");
                    Console.WriteLine("Press Enter to Go Back to the Menu.");
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    if (items.Contains("Bottle of Perfume"))
                    {
                        numberOfBottlesOfPerfume++;
                    }
                    else
                    {
                        items.Add("Bottle of Perfume");
                        numberOfBottlesOfPerfume++;
                    }
                    costs.Add(BOTTLE_OF_PERFUME_PRICE);
                    Console.WriteLine("You Added a Bottle of Perfume to Your Shopping Cart");
                    Console.WriteLine("Press Enter to Go Back to the Menu.");
                    Console.ReadKey();
                    break;
                case "6":
                    Console.Clear();
                    if (items.Contains("Imported Box of Chocolates"))
                    {
                        numberOfImportedBoxesOfChocolates++;
                    }
                    else
                    {
                        items.Add("Imported Box of Chocolates");
                        numberOfImportedBoxesOfChocolates++;
                    }
                    costs.Add(IMPORTED_BOX_OF_CHOCOLATES_PRICE);
                    Console.WriteLine("You Added an Imported Box of Chocolates to Your Shopping Cart");
                    Console.WriteLine("Press Enter to Go Back to the Menu.");
                    Console.ReadKey();
                    break;
                case "7":
                    Console.Clear();
                    if (items.Contains("Imported Bottle of Perfume"))
                    {
                        numberOfImportedBottlesOfPerfume++;
                    }
                    else
                    {
                        items.Add("Imported Bottle of Perfume");
                        numberOfImportedBottlesOfPerfume++;
                    }
                    costs.Add(IMPORTED_BOTTLE_OF_PERFUME_PRICE);
                    Console.WriteLine("You Added an Imported Bottle of Perfume to Your Shopping Cart");
                    Console.WriteLine("Press Enter to Go Back to the Menu.");
                    Console.ReadKey();
                    break;
                case "8":
                    Console.Clear();
                    Console.WriteLine("               Receipt");
                    Cart.PrintReceipt(items, costs, quantity);                    
                    double totalCost = Cart.TotalCosts(costs);
                    double totalTax = Helper.TaxRate(items, costs);
                    Console.WriteLine($"Sales Taxes: ${totalTax}");
                    Console.WriteLine($"Total: ${totalCost}");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please Type in a Number From the Provided Menu.");
                    Console.WriteLine("Press Enter to Go Back to the Menu.");
                    Console.ReadKey();
                    break;

            }
        }
    }
}