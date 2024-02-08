using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientation.Entities.CreditManager;

public class CarCreditManager : BaseCreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Araba kredisi hesaplandı");
    }
}
