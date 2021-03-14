using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Add();
            student.Delete();
        }
    }

    class PersonDal
    {
        public virtual void Add()
        {
            Console.WriteLine("Default method ekleme kodu");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Default method Silme kodu");
        }
    }

    class Student : PersonDal
    {
        public override void Add()
        {
            Console.WriteLine("Öğrenci Ekleme Kodu çalıştı");
            //base.Add();
        }

        public override void Delete()
        {
            Console.WriteLine("Öğrenci silme kodu");
            //base.Delete();
        }
    }
}
