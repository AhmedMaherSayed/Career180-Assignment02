using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2
{
    public class Employee : BaseEntity, IComparable
    {
        public Employee()
        {
            
        }
        public Employee(int id)
        {
            Id = id;
        }
        public Employee(int id, string name) : this(id)
        {
            Name = name;
        }
        public Employee(int id, string name, decimal salary) : this(id, name)
        {
            Salary = salary;
        }
        public Employee(int id, string name, decimal salary, HiringDate hiringDate) : this(id, name, salary)
        {
            HiringDate = hiringDate;
        }
        public Employee(int id, string name, decimal salary, HiringDate hiringDate, Gender gender) : this(id, name, salary, hiringDate)
        {
            Gender = gender;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HiringDate { get; set; }
        public Gender Gender { get; set; }

        public int CompareTo(object? obj) // Ordering Descending
        {
            var passedEmployee = (Employee)obj;

            if (this.HiringDate.Day == passedEmployee.HiringDate.Day 
                && this.HiringDate.Month == passedEmployee.HiringDate.Month
                && this.HiringDate.Year == passedEmployee.HiringDate.Year)
            {
                return 0;
            }
            else if (this.HiringDate.Day >= passedEmployee.HiringDate.Day
                && this.HiringDate.Month == passedEmployee.HiringDate.Month
                && this.HiringDate.Year == passedEmployee.HiringDate.Year)
            {
                return -1;
            }
            else if (this.HiringDate.Month >= passedEmployee.HiringDate.Month
                && this.HiringDate.Year == passedEmployee.HiringDate.Year)
            {
                return -1;
            }
            else if (this.HiringDate.Year >= passedEmployee.HiringDate.Year)
            {
                return -1;
            }
            else
            {
                return 1;
            }
                
        }



        public override string ToString()
            => $"Id = {Id} \t Name = {Name} \t Salary = {Salary} \t Hiring Date = {HiringDate} \t Gender = {Gender}";
    }
}
