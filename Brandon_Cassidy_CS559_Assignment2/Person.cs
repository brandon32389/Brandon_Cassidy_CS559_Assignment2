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
        private int daysUntilBDay;

        public Person()
        {

        }
        public Person(string fn, string ln, DateTime bd)
        {
            firstName = fn;
            lastName = ln;
            birthDate = bd;
            GetDaysUntilBirthday(bd);
        }
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

        public int DaysUntilBDay
        {
            get { return daysUntilBDay; }
        }

        // Find the next occurance of someone's birthday based on their birthdate.
        public void GetDaysUntilBirthday(DateTime dob)
        {
            
            DateTime today = DateTime.Today;
            DateTime birthdayThisYear = new DateTime(today.Year, dob.Month, dob.Day);
            DateTime birthdayNextYear;

            // If the birthday has not yet occured, use the birth date and month with this year, else add one year and subtract today from the new birthday 
            if (today < birthdayThisYear)
            {
                daysUntilBDay = (int)(birthdayThisYear - today).TotalDays;

            }else
            {
                birthdayNextYear = birthdayThisYear.AddYears(1);
                daysUntilBDay = (int)(birthdayNextYear - today).TotalDays;
            }
            

            

        }
    }
}
