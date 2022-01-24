using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
    public class SwitchPatternDemo
    {
        public String GetFormatedString(PersonDataType personData)
        {
            // tuple pattern
            switch (personData.FirstName, personData.MiddleName, personData.LastName)
            {
                // Recurssive pattern
                case (String f, String m, String l):
                    return $"First name {f}, initial of Middle name {m[0]}, Last name {l}";
                case (String f, null, String l):
                    return $"First name {f}, Last name {l}";
                case (null, null, null):
                    return "Ghost";
                default:
                    return "None";
            }

            // switch expression
            /*return (personData.FirstName, personData.MiddleName, personData.LastName) switch
            {
                (String f, String m, String l) => $"First name {f}, initial of Middle name {m[0]}, Last name {l}",
                (String f, null, String l) => $"First name {f}, Last name {l}",
            };*/
        }

        public Decimal GetCourierCharges(PersonDataType personData, Decimal cityCharge) 
            => personData switch
            {
                { FirstName: "Jim1" } => cityCharge * 0.06M,
                { FirstName: "Jim2" } => cityCharge * 0.075M,
                { FirstName: "Jim3" } => cityCharge * 0.05M,            
                // other cases removed for brevity...
                _ => 0M
            };
    }
}
