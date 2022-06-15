using EmployeePayrollMultithreading;
using System.Collections.Generic;
namespace EmpPayrollTest
{
    [TestClass]
    public class EmpTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(employeeId: 1, employeeName: "Rajesh", phoneNumber: "7898625487",address:"Bemetara", departMent:"cse"));
            employeeDetails.Add(new EmployeeDetails(employeeId: 2, employeeName: "Vivek", phoneNumber: "9698625487", address: "Raipur", departMent: "me"));
            employeeDetails.Add(new EmployeeDetails(employeeId: 3, employeeName: "Govind", phoneNumber: "6325625487", address: "Bhilai", departMent: "civil"));
            employeeDetails.Add(new EmployeeDetails(employeeId: 4, employeeName: "Deepak", phoneNumber: "9018625487", address: "Durg", departMent: "physics"));
            employeeDetails.Add(new EmployeeDetails(employeeId: 5, employeeName: "Ramesh", phoneNumber: "9198625487", address: "Kanker", departMent: "EEE"));

            EmpPayRollOpration emppayroll = new EmpPayRollOpration();
            DateTime StartDateTime = DateTime.Now;
            emppayroll.AddEmployee(employeeDetails);
            DateTime StopDateTimes = DateTime.Now;

            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));

            
            //DateTime StartDateTimeThread = DateTime.Now;
            //emppayroll.AddEmployeeThread(employeeDetails);
            //DateTime StopDateTimeThread = DateTime.Now;

            //Console.WriteLine("Duration with threads: " + (StopDateTimeThread - StartDateTimeThread));
        }
    }
}