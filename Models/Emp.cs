using System;
using System.Reflection.Metadata.Ecma335;

namespace ActionToViewEx.Models
{
    public class Emp
    {
        public Int64   EmpID { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public double Salary { get; set; }
        public Emp()
        {
            this.EmpID = 121;
            this.EmpName = "Amol";
            this.DeptName = "Sales";
            this.Salary = 15000;
        }
    }
}
