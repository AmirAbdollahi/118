using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project118.Model
{
    class View118
    {
        public long CodeMelli { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Avenue { get; set; }
        public string Street { get; set; }
        public string Alley { get; set; }
        public int Number { get; set; }
        public string PhoneNumber { get; set; }

        public View118()
        {
            CodeMelli = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            City = string.Empty;
            Avenue = string.Empty;
            Street = string.Empty;
            Alley = string.Empty;
            Number = 0;
            PhoneNumber = string.Empty;
        }

        public View118(long codeMelli, string firstName, string lastName, string city, 
            string avenue, string street, string alley, int number, string phoneNumber)
        {
            CodeMelli = codeMelli;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Avenue = avenue;
            Street = street;
            Alley = alley;
            Number = number;
            PhoneNumber = phoneNumber;
        }
    }
}
