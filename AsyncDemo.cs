using CSharp8Features.DataEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features
{
    class AsyncDemo
    {
        public async Task Demo()
        {
            await foreach (var sub in Service.GetAsyncSubscribers())
            {
                Console.WriteLine($"{sub.FirstName} has subscribed for Fitness service");
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
