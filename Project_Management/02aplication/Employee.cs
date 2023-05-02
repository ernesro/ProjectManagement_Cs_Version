using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication
{
    internal class Employee
    {
        public int Cod { get; }
        public string Dni { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Admin { get; set; }
        public string Password { get; set; }

        public Employee(int cod, string dni, string name, string lastName, string address, string email, string phoneNumber, string admin, string password)
        {
            Cod = cod;
            Dni = dni;
            Name = name;
            LastName = lastName;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            Admin = admin;
            Password = password;
        }

        public Employee() { }
    }
}
