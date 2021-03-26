using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Emircan";
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add();
        }
    }
    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    public class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredPropertyAttribute : Attribute
    {

    }
    class CustomerDal
    {
        [Obsolete("Bu methodu kullanma, ben yeni ekleme methodu yazdım.")]
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Add2()
        {
            Console.WriteLine("Müşteri 2. methodla eklendi");
        }
    }
}
