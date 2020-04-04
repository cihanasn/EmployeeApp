using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    public class GetEmployeesDTO
    {
        public string status { get; set; }
        public List<Employee> data { get; set; }
    }
}
