using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class Patient
    {
        public Patient() { }
        public Patient(string id, string name, string address, string city, decimal age, string gender)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            Age = age;
            Gender = gender;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public decimal Age { get; set; }
        public string Gender { get; set; }
    }
}
