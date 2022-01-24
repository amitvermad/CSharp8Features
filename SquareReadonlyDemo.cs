using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
    public struct SquareReadonlyDemo
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public readonly double Area => (Height * Width);
        public override readonly string ToString() =>
            $"(Total area for height: {Height}, width: {Width}) is {Area}";
    }
}
