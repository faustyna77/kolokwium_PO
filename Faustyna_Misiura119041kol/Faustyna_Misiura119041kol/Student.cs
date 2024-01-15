using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faustyna_Misiura119041kol
{
    internal class Student:Human,IStudent,IHuman
    {
        private int _grade;

        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Ocena musi być z zakresu 1-5.");
                }
                _grade = value;
            }
        }
        

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            Grade = grade;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Student: {FirstName} {LastName}, Ocena: {Grade}");
        }
    public  string ToString()
    {
        return ($"Ocena studenta to {Grade} lub jakaś inna implementacja z interfejsu metody ToString ");
    }
        public void Print()
        {
            Console.WriteLine ($"Student: {FirstName} {LastName}, Grade:{Grade}- nie było dokładnie zawarte co ma się wyswietlac w tej metodzie ");
        }
    }
}
