namespace DrawLineUnitTest
{
    public class Coordinate2d
    {
        public decimal X { get; }
        public decimal Y { get; }

        public Coordinate2d(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public static Coordinate2d operator -(Coordinate2d a, Coordinate2d b) => new Coordinate2d(a.X - b.X, a.Y - b.Y);
        public static Coordinate2d operator +(Coordinate2d a, Coordinate2d b) => new Coordinate2d(a.X + b.X, a.Y + b.Y);
        public static Coordinate2d operator /(Coordinate2d a, decimal facor) => new Coordinate2d(a.X /facor, a.Y / facor);

        public static bool operator >(Coordinate2d a, Coordinate2d b) => a.X > b.X || a.Y > b.Y;

        public static bool operator <(Coordinate2d a, Coordinate2d b) => a.X < b.X || a.Y < b.Y;

        public static bool operator >=(Coordinate2d a, Coordinate2d b) => a.X >= b.X || a.Y >= b.Y;

        public static bool operator <=(Coordinate2d a, Coordinate2d b) => a.X <= b.X || a.Y <= b.Y;
    }
}