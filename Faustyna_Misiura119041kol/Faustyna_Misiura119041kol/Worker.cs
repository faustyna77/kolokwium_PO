using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faustyna_Misiura119041kol
{
    internal class Worker:Human,IWorker,IHuman
    {
        private decimal _weekSalary;
        private int _workHoursPerDay;

        public decimal WeekSalary
        {
            get { return _weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Tygodniowa pensja nie może być ujemna.");
                }
                _weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get { return _workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Liczba godzin pracy dziennie musi być z zakresu 0-24.");
                }
                _workHoursPerDay = value;
            }
        }
        

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5); 
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Pracownik: {FirstName} {LastName}, Stawka za godinee: {MoneyPerHour()}");
        }
        public string ToString()
        {
            return ($"Pracownik: {FirstName} {LastName}, Pensja za godzine: {MoneyPerHour()}");
        }
        public void Print()
        {
            Console.WriteLine( ($"Pracownik: {FirstName} {LastName}, Pensja za godzine: {MoneyPerHour()}"));
        }
    }
}
