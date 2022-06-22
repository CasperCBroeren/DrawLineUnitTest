using System;
using System.Collections.Generic;
using System.Drawing;

namespace DrawLineUnitTest
{
    public class Canvas2d
    {
        private readonly Coordinate2d min;
        private readonly Coordinate2d max;
        private List<Line> LinesDrawn = new List<Line>();

        public Canvas2d(Coordinate2d min, Coordinate2d max)
        {
            this.min = min;
            this.max = max;
        }

        internal void DrawLine(Color color, Coordinate2d a, Coordinate2d b, decimal thickness)
        {
            LinesDrawn.Add(new Line(color, a, b, thickness));
        }

        internal Color SampleColor(Coordinate2d a)
        {
            if (a < min || a > max)
            {
                return Color.Transparent;
            }

            foreach(var line in LinesDrawn)
            {
                if (a >= line.A && a <= line.B)
                {
                    if (line.Descent == 0)
                    {
                        return line.Color;
                    }
                    var projected = line.Project(a.X);
                    if (Math.Abs(projected.Y - a.Y) <= line.Thickness)
                    {
                        return line.Color;
                    }
                } 
            }
            return Color.Transparent;
        }
    }
}