using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtensions;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime curentDateTime = DateTime.Now;
            curentDateTime.Print();
            Console.WriteLine(curentDateTime.IsDayOfWeek(DayOfWeek.Monday));
        }
    }
}
