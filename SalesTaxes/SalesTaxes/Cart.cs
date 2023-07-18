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
                Console.WriteLine($"{item.Name}: {Math.Round(totalPrice + (TaxHelper.ItemTax(item) * item.Quantity), 2).ToString("0.00")} ({item.Quantity} @ {Math.Round(item.Price + TaxHelper.ItemTax(item), 2).ToString("0.00")})");
            }
            else
            {
                Console.WriteLine($"{item.Name}: {Math.Round(totalPrice + TaxHelper.ItemTax(item), 2).ToString("0.00")}");
            }
        }
    }

    public static double TotalCosts(List<ProductLine> items)
    {
        double totalCosts = items.Sum(item => item.Quantity * item.Price) + TaxHelper.TotalTax(items);
        return totalCosts;
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


