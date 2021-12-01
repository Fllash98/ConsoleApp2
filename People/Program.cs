using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humans humans = new Humans("QWE", "ASD", "x");
            Citizen citizen = new Citizen("QWE", "ASD", "x", 127466, "QAZXSW");

            humans.Print();
            citizen.Print();
        }
    }
}
