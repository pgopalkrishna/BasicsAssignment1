using System;
namespace Assignment2
{
    class Program
    {
        static string msg;
        static Program()
        {
            msg = "Hello World";
        }
        private Program() { }
        static void Main(string[] args)
        {
            Console.WriteLine("Msg from static constructor:{0}", msg);

            Employee firstEmployee = new Employee(1, "John", (int)Genders.Male);
            Console.WriteLine("firstEmployee=============");
            ShowEmpDetails(firstEmployee);

            Employee secondEmployee = new Employee(firstEmployee);
            Console.WriteLine("secondEmployee ============= copy constructor denstration======");
            ShowEmpDetails(secondEmployee);
            Console.WriteLine("************************************************");
            //Byval
            Console.WriteLine("======Employee Before call byval==========");
            ShowEmpDetails(secondEmployee);
            SetEmployeeByVal(secondEmployee);
            Console.WriteLine("======Employee After call byval==========");
            ShowEmpDetails(secondEmployee);

            Console.WriteLine("************************************************");

            //ByRef:class, interface,delegate,string,Array of any type are ref types
            Console.WriteLine("======Employee Before call byRef==========");
            ShowEmpDetails(secondEmployee);
            SetEmployeeByRef(ref secondEmployee);
            Console.WriteLine("======Employee After call byRef==========");

            ShowEmpDetails(secondEmployee);
            Console.WriteLine("************************************************");
            int salary = 40000;
            Console.WriteLine("salary:{0}", salary);
            SetSalaryByVal(salary);
            Console.WriteLine("salary after SetSalaryByVal :{0}", salary);
            SetSalaryByRef(ref salary);
            Console.WriteLine("salary after SetSalaryByRef :{0}", salary);
            Console.WriteLine("************************************************");

            //this is to demonstrate, we can create object of class which has a private constructor inside the same class but not outside of that class
            Program OBJ_Program = new Program();
            // we are creating object of Program class inside Program class ,so its valid.
            OBJ_Program.Greeting();
            // Student stud = new Student(); //Here we tried to create instance of class which has private constructor,and its not valid.It gives below error.
            //Error=>CS0112:'Student.Student()' is inaccessible due to its protection level.

            //Boxing
            int integerValue = 10;
            Object obj = integerValue;
            Console.WriteLine("Boxing demo: Obj={0}", obj);
            Console.WriteLine("Unboxing demo: integerValue={0}", (int)obj);
            //Console.WriteLine("Unboxing demo: integerValue={0}", (string)obj);//it will throw error because obj has value of type int & we tried to unbox it into string which is not valid.

            //Vehicle v1 = new Vehicle();//It's not valid because we can't create instance of static class
            Vehicle.name = "Victoria";
            Vehicle.ShowName();

            //Singlton pattern
            Animal Lion = Animal.GetInstance();
            Animal Tiger = Animal.GetInstance();
            if (Lion == Tiger)
            {
                Console.WriteLine("Singleton Successfull");
            }
            else
            {
                Console.WriteLine("Singleton Unsuccessfull");
            }

            //Extension Methods
            int wordCount = msg.WordCount();
            Console.WriteLine("Word count of msg string is: {0}", wordCount);
            wordCount = "This is my string".WordCount();
            Console.WriteLine("Word count of 'This is my string' string is: {0}", wordCount);
            Console.ReadLine();
        }
        public static void ShowEmpDetails(Employee e)
        {
            Console.WriteLine("Employee=> Id : {0},Name : {1},Gender : {2}", e.Id, e.Name, (Genders)e.Gender);
        }
        public static void SetEmployeeByVal(Employee e)
        {
            e.Id = 2;
            e.Name = "Peter";
            e.Gender = (int)Genders.Male;
        }
        public static void SetEmployeeByRef(ref Employee e)
        {
            e.Id = 3;
            e.Name = "Alexa";
            e.Gender = (int)Genders.Female;
        }
        public static void SetSalaryByVal(int salary)
        {
            salary = 80000;
        }
        public static void SetSalaryByRef(ref int salary)
        {
            salary = 90000;
        }
        enum Genders
        {
            Male = 1,
            Female = 2,
            PreferNotToSpecify = 3
        }
        public void Greeting()
        {
            if (DateTime.Now.Hour < 12 && DateTime.Now.Hour >= 5)
            {
                Console.WriteLine("Good Morning");
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 16)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (DateTime.Now.Hour >= 16)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
        }
    }
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
    public class Student
    {
        private static string Name;
        private static string course;
        private Student()
        {
            Name = "John";
            course = ".NET core ";
        }
        //static void Main(string[] args) {
        //    Student stud = new Student();
        //    stud.ShowStudentDetails();
        //    Console.ReadLine();
        //}
        public void ShowStudentDetails()
        {
            Console.WriteLine("Student => Name:{0}, Course : {1}", Name, course);
        }
    }
    public static class Vehicle
    {
        public static string name;
        public static void ShowName()
        {
            Console.WriteLine("Name:{0}", name);
        }
    }
    public sealed class Animal
    {
        private Animal() { }
        private static Animal _animalInstance;
        public static Animal GetInstance()
        {
            if (_animalInstance == null)
            {
                _animalInstance = new Animal();
            }
            return _animalInstance;
        }
    }
    public static class MyExtension
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
