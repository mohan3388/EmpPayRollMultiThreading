using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultithreading
{
    public class EmpPayRollOpration
    {
        public List<EmployeeDetails> employeeDatalist = new List<EmployeeDetails>();
        public void AddEmployee(List<EmployeeDetails> employeeDatalist)
        {
            employeeDatalist.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: "+employeeData.EmployeeName);
                this.AddEmployeePayroll(employeeData);
                Console.WriteLine("Employee added: "+employeeData.EmployeeName);
            }
            );
            Console.WriteLine(this.employeeDatalist.ToString());
        }
        public void AddEmployeePayroll(EmployeeDetails emp)
        {
            employeeDatalist.Add(emp);
        }
        //public void AddEmployeeThread(EmployeeDetails emp)
        //{
        //    employeeDatalist.Add(emp);
        //}
    }
}
