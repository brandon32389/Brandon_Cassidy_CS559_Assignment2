using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brandon_Cassidy_CS559_Assignment2
{
    class Person
    {
        // Internal fields
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        // Public properties
        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
        }
    }
}
