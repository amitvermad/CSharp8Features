using System;
using System.Collections.Generic;

namespace CSharp8Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //// --------------
            Console.WriteLine("Nullable reference");
            var nullableRef = new NullableRefDemo();
            nullableRef.Demo();

            //// --------------
            Console.WriteLine("Async reference");
            var asyncDemo = new AsyncDemo();
            asyncDemo.Demo().Wait();

            //// --------------
            Console.WriteLine("Default interface Demo");
            var loggingDemo = new ConsoleLogging();
            loggingDemo.WriteInfo("WriteInfo is called on ConsoleLogging object");

            ILogger interfaceLoggingDemo = new ConsoleLogging();
            interfaceLoggingDemo.WriteException("Exception is traced using default interface");

            //// --------------
            Console.WriteLine("Switch pattern demo");
            var swithcPatternDemo = new SwitchPatternDemo();
            var person = new PersonDataType("Amit", null, "Verma");
            Console.WriteLine(swithcPatternDemo.GetFormatedString(person));

            //// --------------
            Console.WriteLine("Property pattern demo");
            {
                var swithcPatternDemo = new SwitchPatternDemo();
                var person = new PersonDataType("Jim1", null, "Tom");
                Console.WriteLine($"Courier charges {swithcPatternDemo.GetCourierCharges(person, 25)}");
            }

            //// --------------
            Console.WriteLine("Positional pattern demo");
            var positionalPattern = new PositionalPatternDemo(3, 6);
            Console.WriteLine($"Quadrant is {positionalPattern.GetQuadrant(positionalPattern)}");

            //// --------------
            Console.WriteLine("Indices and Range demo");
            var iRDemo = new IndicesRangeDemo();
            Console.WriteLine($"Person name at index 2 is {iRDemo.GetPersonDataAtIndex(2)}");
            Console.WriteLine($"Person name at second last index is {iRDemo.GetPersonDataAtIndex(2, true)}");
            Console.WriteLine($"People from range lower 0 to upper 3 are");
            foreach (var p in iRDemo.GetPersonDataWithInRange(0, 4))
            {
                Console.WriteLine($"{p.FirstName}");
            }

            //// --------------
            Console.WriteLine("Null colascing operator demo");
            List<Int32> numbers = null;
            int? i = null;

            numbers ??= new List<Int32>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17

            //// --------------
            Console.WriteLine("Readonly members demo");
            var sq = new SquareReadonlyDemo();
            sq.Height = 20.0;
            sq.Width = 25.0;
            Console.WriteLine(sq.ToString());

            //// --------------
            Console.WriteLine("Using members demo");
            using (var resource = new UsingDemo())
            {
                Console.WriteLine("Using resource...");
            }

            using var newWayResource = new UsingDemo();
            Console.WriteLine("Using new way resource...");
            
            //// --------------
            Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            var ind = numbers.IndexOfAny(stackalloc[] { 4, 6, 8 });
            Console.WriteLine(ind);  // output: 3
        }
    }
}
