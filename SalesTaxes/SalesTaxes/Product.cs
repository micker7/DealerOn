using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ProductLine
{
    public ProductLine(int quantity, string name, double price)
    {
        Quantity = quantity;
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public double TaxRate { get; set; }

}