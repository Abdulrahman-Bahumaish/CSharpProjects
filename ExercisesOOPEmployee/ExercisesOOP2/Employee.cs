using ExercisesOOP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a class named Employee that has three fields:
//name, salary, and address.
// Overload the constructor and implement the chaining technique.
// The default constructor should print this message "Welcome to our company"
//and set these default values to the class fields : "Unknown", 30000, "Mukalla"

namespace ExercisesOOP2
{
    internal class Employee
    {
        private string Name;
        private double Salary;
        private string Address;
        public Employee() {
            Console.WriteLine("Welcome To Our Compamy.");
        } 
        
        public Employee(string Name){
            this.Name = Name;
            Console.WriteLine($"Name Is :{this.Name}");
        }
        public Employee(string Name, double Salary, string Address) : this(Name)
        {
            this.Salary = Salary;
            this.Address = Address;
            Console.WriteLine($"Salary Is :{this.Salary}");
            Console.WriteLine($"Address Is :{this.Address}");
        }
    }
}
