using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
    class UsingDemo : IDisposable
    {
        public UsingDemo()
        {
            Console.WriteLine("Resource created...");
        }
        public void Dispose()
        {
            Console.WriteLine("Resource disposed..");
        }
    }
}
