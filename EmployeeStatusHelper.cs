using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApplication
{
    public class EmployeeStatusHelper
    {
        public static List<EmployeeStatus> GetEmployeeStatus()
        {
            return new List<EmployeeStatus>()
            {
                new EmployeeStatus {Id = 0, Name = "Wszyscy pracownicy"},
                new EmployeeStatus {Id = 1, Name = "Obecni pracownicy"},
                new EmployeeStatus {Id = 2, Name = "Byli pracownicy"}
            };
        }
    }
}
