using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientation.Entities.Customers;

public class Company : Customer
{
    // Ek özellikler
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
}
