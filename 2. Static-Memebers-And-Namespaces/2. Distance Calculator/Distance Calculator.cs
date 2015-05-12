namespace _2.Distance_Calculator
{

    using System;

    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            double deltaX = point1.X - point2.X;
            double deltaY = point1.Y - point2.Y;
            double deltaZ = point1.Z - point2.Z;

            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
        }

        public class Point3D
        {
            private static readonly Point3D StartingPoint = new Point3D(0, 0, 0);

            public Point3D(double x, double y, double z)
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

            public double X { get; set; }

            public double Y { get; set; }

            public double Z { get; set; }

            public static Point3D ReturnToStart()
            {
                return StartingPoint;
            }

            public override string ToString()
            {
                return String.Format("[X = {0}, Y = {1}, Z = {2}]", this.X, this.Y, this.Z);
            }

            static void Main(string[] args)
            {
                Point3D first = new Point3D(10, 5, 3);
                Point3D second = new Point3D(3, 5, 3);

                Console.WriteLine(DistanceCalculator.CalculateDistance(first, second));
            }
        }
    }
}
