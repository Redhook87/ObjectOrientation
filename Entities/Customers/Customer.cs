using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientation.Entities.Customers;

public class Customer
{
    public Customer()
    {
        Console.WriteLine("Müşteri Nesnesi Başlatıldı");
    }

    // Özellikler
    public int Id { get; set; }
    public string City { get; set; }
    public string FirstName { get; set; }
}
