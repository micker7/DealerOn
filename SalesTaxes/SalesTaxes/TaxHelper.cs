using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TaxHelper
{
    public static double TaxRate(ProductLine item)
    {
        double taxRate =0.0;
        if (item.Name.Contains("Book") || item.Name.Contains("Chocolate") || item.Name.Contains("Pills"))
        {
            taxRate = 0;
        }
        else
        {
            taxRate += 0.1;
        }
        if (item.Name.Contains("Imported"))
        {
            taxRate += 0.05;
        }
        
        return taxRate;
    }

    public static double TotalTax(List<ProductLine> items)
    {
        double totalTax = items.Sum(item => Math.Ceiling(item.Price * item.Quantity * TaxRate(item) / 0.05) * 0.05);
        //double totalRoundedTax = Math.Ceiling(totalTax / 0.05) * 0.05;
        //return Math.Round(totalRoundedTax,2); 
        return totalTax;
    }

    public static double ItemTax(ProductLine item)
    {
        double tax = item.Price * TaxRate(item);
        double roundedTax = Math.Ceiling(tax / 0.05) * 0.05;
        return Math.Round(roundedTax, 2);
    }
}




