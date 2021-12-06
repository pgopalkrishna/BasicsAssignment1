using System;
namespace Assignment2
{
    public class Student
    {
        private static string Name;
        private static string Course;
        private Student()
        {
            Name = "John";
            Course = ".NET core ";
        }
        //static void Main(string[] args) {
        //    Student stud = new Student();
        //    stud.ShowStudentDetails();
        //    Console.ReadLine();
        //}
        public void ShowStudentDetails()
        {
            Console.WriteLine("Student => Name:{0}, Course : {1}", Name, Course);
        }
    }
}
