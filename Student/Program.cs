using System;
using MyExstensions_;
using Student_;

namespace Program_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { FirstName = "Qwerty", LastName = "123" };

            string fullName =  student.GetFullName();
            Console.WriteLine(fullName);
        }
    }
}
