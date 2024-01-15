using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faustyna_Misiura119041kol
{
    abstract class Human:IHuman
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract void DisplayInfo();

        private string ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Imię lub nazwisko nie może być puste ani składać się tylko z białych znaków.");
            }
            return name;
        }
        public void Print()
        {
            Console.WriteLine( ($"Imie {FirstName} nazwisko{LastName}- jakaś dowolna implementacja metody Print"));
        }


    }
}
