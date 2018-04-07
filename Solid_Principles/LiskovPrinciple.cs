using System;
using System.Collections;
using System.Collections.Generic;

namespace Solid_Principles
{
    interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
    interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
    public abstract class EmployeeLSP : IEmployeeBonus, IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        protected EmployeeLSP() { }
        protected EmployeeLSP(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return string.Format($"ID : {this.ID}, Name : {this.Name}");
        }
        public abstract decimal GetMinimumSalary();
    }
    public class PermanentEmployeeLSP : EmployeeLSP
    {
        public PermanentEmployeeLSP() { }
        public PermanentEmployeeLSP(int ID, string Name) : base(ID, Name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.1M;
        }
        public override decimal GetMinimumSalary()
        {
            return 15000M;
        }
    }
    public class TemporaryEmployeeLSP : EmployeeLSP
    {
        public TemporaryEmployeeLSP() { }
        public TemporaryEmployeeLSP(int ID, string Name) : base(ID, Name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.05M;
        }
        public override decimal GetMinimumSalary()
        {
            return 10000;
        }
    }
    public class ContractEmployeeLSP : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ContractEmployeeLSP() { }
        public ContractEmployeeLSP(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public decimal GetMinimumSalary()
        {
            return 15000M;
        }
    }
    public class LSPMain
    {
        public static void Main(string[] args)
        {
            List<EmployeeLSP> employees = new List<EmployeeLSP>
            {
                new PermanentEmployeeLSP(1, "Glenn McGrath"),
                new TemporaryEmployeeLSP(2, "Peter Parker")
            };
            foreach (var emp in employees)
            {
                Console.WriteLine($"Employee: {emp.Name} ," +
                                  $"Bonus: {emp.CalculateBonus(100000).ToString()} ," +
                                  $"Minimum Salary: {emp.GetMinimumSalary()}");
            }

            Console.WriteLine("-----------------------All Employees -----------------------------------");
            List<IEmployee> empAllTypes = new List<IEmployee>
            {
                new PermanentEmployeeLSP(1, "Glenn McGrath"),
                new TemporaryEmployeeLSP(2, "Peter Parker"),
                new ContractEmployeeLSP(3, "Jason Joe")
            };
            foreach (var emp in empAllTypes)
            {
                Console.WriteLine($"Employee: {emp.Name} ," +
                                  $"Minimum Salary: {emp.GetMinimumSalary()}");
            }

            Console.ReadLine();
        }
    }
}
