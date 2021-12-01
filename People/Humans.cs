using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Humans
    {
        protected string SecondName { get; set; }
        protected string FirstName { get; set; }
        protected string Gender { get; set; }

        public Humans(string secondName, string firstName, string gender)
        {
            SecondName = secondName;
            FirstName = firstName;  
            Gender = gender;
        }
        public virtual void Print()
        {
             
            Console.WriteLine("Фамилия: {0}\n" +
                              "Имя: {1}\n" +
                              "Пол: {2}", 
                              SecondName, FirstName, Gender);
        }
    }
}
