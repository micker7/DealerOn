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
        if (item.Name.Contains("Imported"))
        {
            taxRate += 0.05;
        }
        else if (item.Name.Contains("Book") || item.Name.Contains("Bar") || item.Name.Contains("Pills"))
        {
            taxRate = 0;
        }
        else
        {
            taxRate += 0.1;
        }
        double roundedtaxRate = Math.Ceiling(taxRate / 0.05) * 0.05;
        return roundedtaxRate;
    }

    public static double TotalTax(List<ProductLine> items)
    {
        double totalTax = items.Sum(item => item.Price * item.Quantity * TaxRate(item));
        double roundedTaxes = Math.Round(totalTax, 2);
        return roundedTaxes;

    }
}




