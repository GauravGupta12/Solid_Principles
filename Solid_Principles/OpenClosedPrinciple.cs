using System;
namespace Solid_Principles
{
    // This file contains all the classes, sub-classes, interfaces required to demonstrate Open-Closed Principle
    // In actual projects, they may have their own separate files.
    public abstract class Employee
    {
        // Employee class is open for extension b ut closed for modification as modications are 
        // implemented by derived classes
        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        protected Employee () {}
        protected Employee(int ID, string Name) 
        {
            this.ID = ID;
            this.Name = Name;
        }
        public abstract decimal CalculateBonus(decimal salary);
		public override string ToString()
		{
            return string.Format($"ID : {this.ID}, Name : {this.Name}");
		}

	}

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(){}
        public PermanentEmployee(int ID, string Name) : base(ID,Name) {}
		public override decimal CalculateBonus(decimal salary)
		{
            return salary * 0.1M;
		}
	}
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee() { }
        public TemporaryEmployee(int ID, string Name) : base(ID, Name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.05M;
        }
    }
    public class OCPMain
    {
        public static void Main1(string[] args)
        {
            Employee empPermanent = new PermanentEmployee(1, "Glenn McGrath");
            Employee empTemp = new TemporaryEmployee(2, "Peter Parker");

            Console.WriteLine($"Employee: {empPermanent.Name} ," +
                              $"Bonus: {empPermanent.CalculateBonus(100000).ToString()}");
            Console.WriteLine($"Employee: {empTemp.Name} ," +
                              $"Bonus: {empTemp.CalculateBonus(100000).ToString()}");
        }
    }
}
