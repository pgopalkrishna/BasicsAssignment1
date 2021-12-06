using System;
namespace Assignment2
{
    public class Employee
    {
        public int Id;
        public string Name;
        public int Gender;
        //static constructor
        static Employee()
        {
            Console.WriteLine("from Employee's static constructor");
        }
        //Although this class has private constructor ,it will not get called due to public constructor.
        private Employee()
        {
            Console.WriteLine("hi from private constructor");
        }
        //public  Employee() { 
        //}
        //parameterized constructor
        public Employee(int id, string name, int gender)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
        }
        //copy constructor
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Gender = emp.Gender;
        }
    }
}
