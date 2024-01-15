using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faustyna_Misiura119041kol
{
    internal class Program
    {

        public static void Main()
        {

            try
            {
                List<Student> students = new List<Student>
                {
                    new Student("Anna ", "Nowak", 5),
                    new Student("Karol", "Karolczuk", 2),
                     new Student("Wiktoria", "Sosna", 5),
                    new Student("Alicja", "Barlewicz", 2),
                     new Student("Klaudia", "Waw", 5),
                    new Student("Bob", "Smith", 2),
                     new Student("Ela", "Ziobro", 5),
                    new Student("Antonina", "Swiątek", 2),
                     new Student("Aneta", "Ziobro", 5),
                    new Student("Klaudia", "Swiątek", 2),

                };

                List<Worker> workers = new List<Worker>
                {
                      new Worker("Anna ", "Nowak",34, 5),
                    new Worker("Karol", "Karolczuk",12, 2),
                     new Worker("Wiktoria", "Sosna",10, 5),
                    new Worker("Alicja", "Barlewicz",300, 2),
                     new Worker("Klaudia", "Waw",230, 5),
                    new Worker("Bob", "Smith", 100,2),
                     new Worker("Ela", "Ziobro", 200,5),
                    new Worker("Antonina", "Swiątek",300, 2),
                     new Worker("Aneta", "Ziobro", 689,5),
                    new Worker("Klaudia", "Swiątek",300, 2),
                    new Worker("Bob", "Johnson", 500, 8),
                    new Worker("Eve", "Williams", 600, 7),
                    //new Worker("InvalidFirstName", "InvalidLastName", -500, 9), // Przykład błędnych danych
                };

                // Wykorzystałam compare to 
                students.Sort((x, y) => x.Grade.CompareTo(y.Grade));
                Console.WriteLine("Studenci:");
                foreach (var student in students)
                {
                    student.DisplayInfo();
                }

                // Sortowanie według stawki za godzzie
                workers.Sort((x, y) => y.MoneyPerHour().CompareTo(x.MoneyPerHour()));
                Console.WriteLine("\nPracownicy:");
                foreach (var worker in workers)
                {
                    worker.DisplayInfo();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }


    }

    }

