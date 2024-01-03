using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApplication
{
    public static class EmployeeTypesHelper
    {
        public static List<EmployeeTypes> GetEmployeeType()
        {
            return new List<EmployeeTypes>()
            {
                new EmployeeTypes {Id = 0, Name = "Kierownik"},
                new EmployeeTypes {Id = 1, Name = "Kasjer"},
                new EmployeeTypes {Id = 2, Name = "Sprzedawca"}
            };
        }
    }
}
