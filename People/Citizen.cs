using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Citizen : Humans
    {
        protected int PassportID { get; set; }
        protected string ResidensAddress { get; set;}
        public Citizen(string secondName, string firstName, string gender, int pasportID, string residensAddress) : base(secondName, firstName, gender)
        {
            PassportID = pasportID;
            ResidensAddress = residensAddress;
        }
        public override void Print()
        {
            Console.WriteLine(PassportID +"\n"+ 
                              ResidensAddress);
        }

    }
}
