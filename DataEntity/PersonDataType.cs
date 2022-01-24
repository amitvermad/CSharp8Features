using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
#nullable enable
    public class PersonDataType
    {
        public String FirstName { get; set; }

        public String /*?*/ MiddleName { get; set; }

        public String LastName { get; set; }

        public PersonDataType(String firstName, String secondName)
        {
            this.FirstName = firstName;
            //// this.MiddleName = null; //// to avoice null ref warning 
            //// but then a new warning come that is null cannot set to null. to remove it set middlename as ?
            this.LastName = secondName;
        }

        public PersonDataType(String firstName, String middleName, String lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }
    }
}
