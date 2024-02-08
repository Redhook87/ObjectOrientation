using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientation.Entities.CreditManager;

public class TeacherCreditManager : BaseCreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Öğretmen kredisi hesaplandı");
    }

    public override void Save()
    {
        // Özel kaydetme işlemleri burada yapılabilir
        base.Save();
    }
}
