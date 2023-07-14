using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Helper
{
   
    public static double TaxRate(List<string> items, List<double> costs)
    {
        double taxRate;

        if (items.Contains("book") || items.Contains("chocolate") || items.Contains("pills"))
        {
            taxRate = 0.00;
        }
        else
        {
            taxRate = 0.1;
        }

        if (items.Contains("imported"))
        {
            taxRate += 0.05;
        }

        return taxRate;

    }
}




