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
        Console.WriteLine("Items:\t\tPrices:");
        Console.WriteLine("-------------------------------------------");

        foreach (var item in items)
        {
            double totalPrice = item.Price * item.Quantity;
            if (item.Quantity > 1)
            {

                Console.WriteLine(item.Name + ": " + totalPrice + " (" + item.Quantity + " @ " + item.Price + ")");
            }
            else
            {
                Console.WriteLine(item.Name + ": " + totalPrice);
            }
        }
    }

    public static double TotalCosts(List<ProductLine> items)
    {
        double totalPrices = items.Sum(item => item.Quantity * item.Price + TaxHelper.TotalTax(items));
        double roundedCostAmount = Math.Round(totalPrices, 2);
        return roundedCostAmount;
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
        Console.WriteLine("Press Any Key to Go Back to the Menu.");
        Console.ReadKey();

    }
}


