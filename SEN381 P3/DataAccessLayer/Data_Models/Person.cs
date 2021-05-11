using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public abstract class Person
    {
        private string id;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string address;
        private string email;

        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

        public Person(string id, string firstName, string lastName, string phoneNumber, string address, string email)
        {
            this.firstName = firstName;
            this.address = address;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            if (id == null)
                this.id = this.GetHashCode().ToString();
            else
                this.id = id;
        }

        protected Person(string firstName, string lastName, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        private int CharToInt(string word)
        {
            int value = 0;
            foreach (char letter in word)
                value += (int)letter;
            return value;
        }

        public override int GetHashCode()
        {
            int hash = 1;
            foreach (string word in new string[] { FirstName, LastName, PhoneNumber})
                hash *= CharToInt(word);
            return hash;
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Person) obj).Id);
        }

        public override string ToString()
        {
            return string.Format(
                "ID: {0}\n"+
                "Name: {1} {2}\n"+
                "Phone Number: {3}", Id, FirstName, LastName, PhoneNumber);
        }
    }
}
