using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TaxHelper
{

    public static double TaxRate(List<ProductLine> items)
    {
        double taxRate;
        if (items.Name.Contains("imported"))
        {
            taxRate = 0.05;
        }
        if (items.Name.Contains("book") || items.Name.Contains("bar") || items.Name.Contains("pills"))
        {
            taxRate = 0.00;
        }
        else
        {
            taxRate = 0.1;
        }
        double totalTax = items.Sum(item => item.Price * item.Quantity * taxRate);
        double roundedTaxes = Math.Round(totalTax, 2);
        double taxRateTotal = roundedTaxes;
        return taxRateTotal;
    }

    //public static double TotalTax(List<ProductLine> items)
    //{
    //    double totalTax = items.Sum(item => item.SalesTax);
    //    return totalTax;

    //}
       
}




