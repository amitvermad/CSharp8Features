using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
    public class IndicesRangeDemo
    {
        public PersonDataType[] GetPersonDataWithInRange(Int32 lowerRange, Int32 upperRange)
        {
            PersonDataType[] people =
               {
                new PersonDataType ("Jim", "Carry", "Dosh"),
                new PersonDataType ("Jim1", "Carry1", "Dosh1"),
                new PersonDataType ("Jim2", "Dosh2"),
                new PersonDataType ("Jim3", "Carry3", "Dosh3"),
                new PersonDataType ("Jim4", "Dosh4"),
                new PersonDataType ("Jim5", "Carry5", "Dosh5"),
            };
            return people[lowerRange..upperRange];
        }

        public String GetPersonDataAtIndex(Int32 index, Boolean isReverseOrder = false)
        {
            PersonDataType[] people =
               {
                new PersonDataType ("Jim", "Carry", "Dosh"),
                new PersonDataType ("Jim1", "Carry1", "Dosh1"),
                new PersonDataType ("Jim2", "Dosh2"),
                new PersonDataType ("Jim3", "Carry3", "Dosh3"),
                new PersonDataType ("Jim4", "Dosh4"),
                new PersonDataType ("Jim5", "Carry5", "Dosh5"),
            };

            return isReverseOrder ? people[^index].FirstName : people[index].FirstName;

        }
    }
}
