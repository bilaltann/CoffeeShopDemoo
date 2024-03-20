using CoffeeShopDemoo.Abstract;
using CoffeeShopDemoo.Adapters;
using CoffeeShopDemoo.Concrete;

namespace CoffeeShopDemoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer
            {
                DateOfBirth = new DateTime(2003, 11, 2),
                FirstName = "Bilal",
                LastName = "Tan",
                NationalityId = "12619594344"
            });
            Console.ReadLine();
        }
    }

}
