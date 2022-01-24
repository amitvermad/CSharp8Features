using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features.DataEntity
{
    static class Service
    {
        public static IEnumerable<PersonDataType> GetSubscribers()
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

            foreach (var p in people) yield return p;
        }

        public static async IAsyncEnumerable<PersonDataType> GetAsyncSubscribers()
        {
            List<PersonDataType> people = new List<PersonDataType>();
            people.Add(new PersonDataType("Jim", "Carry", "Dosh"));
            people.Add(new PersonDataType("Jim1", "Carry1", "Dosh1"));
            people.Add(new PersonDataType("Jim2", "Dosh2"));
            people.Add(new PersonDataType("Jim3", "Carry3", "Dosh3"));
            people.Add(new PersonDataType("Jim4", "Dosh4"));
            people.Add(new PersonDataType("Jim5", "Carry5", "Dosh5"));
                                    
            foreach (var p in people) 
             {
                yield return p;
                await Task.Delay(500);
             }            
        }
    }
}
