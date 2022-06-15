using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultithreading
{
    public class EmployeeDetails
    {
        public int EmployeeId { get; set; } 
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
       public string Address { get; set; }
       public string DepartMent { get; set; }

        public EmployeeDetails(int employeeId, string employeeName, string phoneNumber, string address, string departMent)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.DepartMent = departMent;
        }

     
    }
}
