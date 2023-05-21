using ExercisesOOP3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a class called Person that has firstName, lastName, and email fields.
// Add read and write property for all fields.
// Add GetFullName and Print methods.
// The Print method prints the full name and the email.
// Note that the email should contain @ and end with .com

namespace ExercisesOOP3
{
    internal class Person
    {
        private string FirstName;
        private string LastName;
        private string Email;

        public string Firstname
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string Lastname
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string Emails
        {
            get { return Email; }
            set {
                if(value.Contains("@")&& value.EndsWith(".com"))
                {
                    Email = value;
                }
                else {Console.WriteLine("Email Must Contain @ And End With.com"); }
            }
        }

        public string GetFullName()
        {
            return($"Full Name Is :{FirstName} {LastName}");
        }

        public void Print()
        {
            Console.WriteLine($"Name :{GetFullName()}");
            Console.WriteLine($"Your Email Is :{Email}");
        }
    }
}
