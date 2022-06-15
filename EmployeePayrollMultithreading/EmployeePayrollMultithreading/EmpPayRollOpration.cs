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
        public void AddEmployeePayrollThread(List<EmployeeDetails> employeeDatalist)
        {
            employeeDatalist.ForEach(employeeData =>

            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                    this.AddEmployeePayrollThread(employeeData);
                Console.WriteLine("Employee added: " + employeeData.EmployeeName);

            });
            thread.Start();
        });
            Console.WriteLine(this.employeeDatalist.Count);
        }

       

        
        public void AddEmployeePayroll(EmployeeDetails emp)
        {
        employeeDatalist.Add(emp);
        }

        public void AddEmployeePayrollThread(EmployeeDetails emp)
        {
            employeeDatalist.Add(emp);
        }
    }
}
