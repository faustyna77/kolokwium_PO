using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faustyna_Misiura119041kol
{
    internal interface IWorker
    {


        decimal WeekSalary { get; }
         int WorkHoursPerDay { get;  }

        decimal MoneyPerHour();
        string ToString();

    }
}
