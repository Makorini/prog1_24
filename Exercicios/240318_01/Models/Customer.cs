using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240318_01.Models
{
    public class Customer
    {
        public int CustomerId {get; set; }
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public DateTime BirthDate {get; set; }
        public string EmailAddress {get; set; }
        //public Address Address address1 {get; set}
        //public Address Address address2 {get; set}

        // atributos para Lista dse endereços
        public List<Address> Addresses = 
        new List<Address>();

        public bool Validade() {
            return true;
        }
    }
}