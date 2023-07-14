using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

public class Cart
{
    public static void PrintReceipt(List<string> items, List<double> costs, List<int> quantity)
    {

      
        Console.WriteLine("Items:\t\t\tPrices:");
        Console.WriteLine("----------------------------------------------");

        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{items[i]}:\t{costs[i]:C}");
        }

        if()

    }

    public static double TotalCosts(List<double> costs)
    {
        double totalCost = costs.Sum();
        return totalCost;


    }
}


