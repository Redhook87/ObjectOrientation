//değer tip value type
//int number1 = 10;
//int number2 = 20;
//number1 = number2;
//number2 = 100;
//
//Console.WriteLine(number1);
//
////array reference type//diziler ref. tiptir
////newlemek(örneğini bellekte oluşturur).
//int[] numbers1 = new[] { 1, 2, 3 };
//int[] numbers2 = new[] { 10, 20, 30 };
//numbers1 = numbers2;
//
//numbers2[0] = 1000;
//
//Console.WriteLine(numbers1[0]);

////class: yapıcağımız işlemleri tutan veya herhangi bir konuda bilgi tutan yapılardır.
//
//CreditManager creditManager = new CreditManager();
//creditManager.Calculate();
//creditManager.Calculate();
//creditManager.Save();
//
//
////örneğini oluşturmak, instance oluşturmak, instance creation
//Customer customer = new Customer();
//customer.Id = 1;
//customer.City = "İstanbul";
//
//
//CustomerManager customerManager = new CustomerManager(customer);
//customerManager.Save();
//customerManager.Delete();
//
//Company company = new Company();
//company.TaxNumber = "200000";
//company.CompanyName = "Razer";
//company.Id = 100;
//
//CustomerManager customerManager2 = new CustomerManager(new Company());
//
//
//Person person = new Person();
//person.FirstName = "";
//person.NationalIdentity = "";
//
//Customer c1 = new Customer();
//Customer c2 = new Person();
//Customer c3 = new Company();
//
//Console.ReadLine();
//




//IoC Container
CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
customerManager.GiveCredit();
class CreditManager

{
    //method /operation /operasyonları tutar
    public void Calculate(int creditType)
    {
        //sonar qube 
        if (creditType == 1) //esnaf
        {

        }
        if (creditType == 2)//ogretmen
        {

        }

        Console.WriteLine("Hesaplandı");
    }

    public void Save()
    {
        Console.WriteLine("Kredi verildi");
    }
}

//DRY(DO NOT REPEAT YOURSELF) kendini tekrar etme

interface ICreditManager
{
    void Calculate();
    void Save();
}

abstract class BaseCreditManager : ICreditManager
{
    public abstract void Calculate();

    public virtual void Save()
    {
        Console.WriteLine("Kaydeildi");
    }
}

class TeacherCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        //hesaplamalar
        Console.WriteLine("Öğretmen kredisi hesaplandı");
    }

    public override void Save()
    {
        //
        base.Save();
        //
    }
}

class MilitaryCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Asker kredisi hesaplandı");
    }
}

class CarCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Araba kredisi hesaplandı");
    }
}

//SOLID
class Customer
{
    public Customer()
    {
        Console.WriteLine("Müşteri Nesnesi Başlatıldı");
    }
    //property /getter setter
    public int Id { get; set; }
    public string City { get; set; }
    public string FirstName { get; internal set; }
}

class Person : Customer
{
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public string NationalIdentity { get; set; }
}

class Company : Customer
{
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
}

//Katmanlı mimariler
class CustomerManager
{
    private Customer _customer;
    ICreditManager _creditManager;
    public CustomerManager(Customer customer, ICreditManager creditManager)
    {
        _customer = customer;
        _creditManager = creditManager;

    }
    //bir müşteri nesnesini parametre olarak gönderiyoruz.
    public void Save()
    {
        Console.WriteLine("Müşteri Kaydedildi: ");
    }

    public void Delete()
    {
        Console.WriteLine("Müşteri Silindi: ");
    }

    public void GiveCredit()
    {
        _creditManager.Calculate();
        Console.WriteLine("Kredi Verildi");
    }
}
//constructor kelime anlamı yapıcı blok olarak düşünebilirsin
//interface ler referance tiptir
