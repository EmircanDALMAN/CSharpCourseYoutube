using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " "+ customer.LastName + " Eklendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Silindi");
        }
    }
}
