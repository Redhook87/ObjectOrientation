using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientation.Entities.Customers;

public class Person : Customer
{
    // Ek özellikler
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
}
