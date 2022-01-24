using System;
using System.Collections.Generic;
using CSharp8Features.DataEntity;
using System.Text;

namespace CSharp8Features
{
    class NullableRefDemo
    {
        public void Demo()
        {
            var susbcribers = Service.GetSubscribers();
            var names = GetNames(susbcribers);
            foreach (var name in names)
            {
                Console.WriteLine($"{name} has subscribed for Fitness service");
            }
            
        }

        /// <summary>
        /// Get lsit of names of person living in community
        /// </summary>
        /// <param name="community"></param>
        /// <returns></returns>
        static IEnumerable<String> GetNames(IEnumerable<PersonDataType> community)
        {
            foreach (var personData in community)
            {
                yield return GetName(personData);
            }
        }

        /// <summary>
        /// Get Name of person
        /// </summary>
        /// <param name="personData"></param>
        /// <returns></returns>
        static String GetName(PersonDataType personData)
        {
            return $"{personData.FirstName} {personData.MiddleName} {personData.LastName}";
        }
    }
}
