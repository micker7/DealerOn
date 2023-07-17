using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

public class Cart
{
    public static void PrintReceipt(List<ProductLine> items)
    {
        Console.WriteLine("Items:\t\t\tPrices:");
        Console.WriteLine("----------------------------------------------");

        foreach (var item in items)
        {
            double totalPrice = item.Price * item.Quantity;

            Console.WriteLine($"{item.Quantity} {item.Name}:\t{totalPrice:C}");
        }
    }

    public static double TotalCosts(List<ProductLine> items)
    {
        double totalCost = items.Sum(item => item.Price);
        return totalCost;
    }

    public static void AddItemToCart(List<ProductLine> items, double itemPrice, string itemName)
    {
        int index = items.FindIndex(item => item.Name == itemName);
        if (index != -1)
        {
            items[index].Quantity++;
        }
        else
        {            
            items.Add(new ProductLine(1, itemName, itemPrice));
        } 
        
        Console.Clear();
        Console.WriteLine($"You Added a {itemName} to Your Shopping Cart");
        Console.WriteLine("Press Enter to Go Back to the Menu.");
        Console.ReadKey();

    }
}


