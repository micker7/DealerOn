using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Helper
{
   
    public static double TaxRate(string itemName)
    {
        double taxRate;
            
            if (itemName.Contains("book") || itemName.Contains("chocolate") || itemName.Contains("pills"))
            {
                taxRate = 0.00;
            }
            else
            {
                taxRate = 0.1;
            }

            if (itemName.Contains("imported"))
            {
                taxRate = 0.05;
            }
        return taxRate;

    }

    public static double TotalTax(List<ProductLine> items)
    {
        double totalTax = items.Sum(item => item.SalesTax);
        return totalTax;

    }
       
}




