using System;
using Student_;

namespace MyExstensions_
{
    static class MyExstensions
    {
        public static string GetFullName(this Student student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }
}
