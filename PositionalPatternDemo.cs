using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
    public enum Quadrant
    {
        Unknown,
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder
    }

    class PositionalPatternDemo
    {
        public int X { get; }
        public int Y { get; }

        public PositionalPatternDemo(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);

        public Quadrant GetQuadrant(PositionalPatternDemo point) => point switch
        {
            (0, 0) => Quadrant.Origin,
            var (x, y) when x > 0 && y > 0 => Quadrant.One,
            var (x, y) when x < 0 && y > 0 => Quadrant.Two,
            var (x, y) when x < 0 && y < 0 => Quadrant.Three,
            var (x, y) when x > 0 && y < 0 => Quadrant.Four,
            var (_, _) => Quadrant.OnBorder,
            _ => Quadrant.Unknown
        };
    }

}
