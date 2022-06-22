using System.Drawing;

namespace DrawLineUnitTest
{
    public class Line
    {

        public Line(Color color, Coordinate2d a, Coordinate2d b, decimal thickness)
        {
            Color = color;
            A = a;
            B = b;
            Thickness = thickness;
        }

        public Color Color { get; }
        public Coordinate2d A { get; }
        public Coordinate2d B { get; }
        public decimal Thickness { get; }

        public decimal Descent
        {
            get
            {
                var bNormalized = B - A;
                return bNormalized.X == 0
                    ? 0
                    : bNormalized.Y / bNormalized.X;
            }
        }

        public Coordinate2d Project(decimal a)
        {
            return new Coordinate2d(a, a * Descent);
        }
    }
}