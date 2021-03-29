using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Emircan",
                LastName = "Dalman"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);

        }
    }
}
