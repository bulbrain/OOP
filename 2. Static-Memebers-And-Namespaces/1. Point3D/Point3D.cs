namespace Point3D
{
    using System;
    public class Point3D
    {
        private static readonly Point3D StartingPoint = new Point3D(0, 0, 0);

        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get { return this.x; }
            set
            {
                if (double.IsNaN(this.x))
                {
                    throw new ArgumentException("Must be a number");
                }
                this.x = value;
            }
        }

        public double Y
        {
            get { return this.y; }
            set
            {
                if (double.IsNaN(this.y))
                {
                    throw new ArgumentException("Must be a number");
                }
                this.y = value;
            }
        }

        public double Z
        {
            get { return this.z; }
            set
            {
                if (double.IsNaN(this.z))
                {
                    throw new ArgumentException("Must be a number");
                }
                this.z = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        }

        static Point3D start()
        {
            return StartingPoint;
        }

        public static void Main(string[] args)
        {
            Point3D test = new Point3D(1, 2, 3);
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}