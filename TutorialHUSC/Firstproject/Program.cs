using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5;
            b = 10;
            c = a + b;
            Console.WriteLine(a + " + " + b + " = " + c);
            Console.WriteLine(String.Format("{0} + {1} = {2}", a, b, c));
            Console.WriteLine($"{a} + {b} = {c}");

            int n = 10;
            if (MathHUSC.IsOdd(n))
                Console.WriteLine($"{n} la so le");
            else
                Console.WriteLine($"{n} la so chan");
            Console.ReadKey();
        }
    }

    class MathHUSC
    {
        /// <summary>
        /// kiểm tra một số là chẵn hay lẻ , bấm ///
        /// </summary>
        /// <param name="n">số cần kiểm tra </param>
        /// <returns>
        /// True nếu n là số lẻ 
        /// False nếu n là số chẵn 
        /// </returns>
        public static bool IsOdd(int n)
        {
            if (n % 2 == 0)

                return true;
            return false;

        }
    }

    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point()
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
        }

        public virtual double Distance()
        {
            var d = Math.Sqrt(x * x + y * y);
            return d;
        }
        public double Distance(Point p)
        {
            var d = Math.Sqrt(Math.Pow(x - p * x, 2) + Math.Pow(y - p * y, 2));
            return d;
        }
        public static double Distance(Point p1, Point p2)
        {
            var d = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
            return d;
        }
        class Cricle
        {
            public double r { get; set; }

            public Cricle()
            {

            }
            public Cricle(double r)
            {
                this.r = r;
            }
            public static double Premeter(double r)
            {
                return (2 * r) * Math.PI;
            }
            public static double Area(double r)
            {
                return r * r * Math.PI;
            }
            public static Distance(Cricle c1, Cricle c2)
            {

            }
        }

    }

    class Point 3D : Point 
        {
        public double z { get; set; }

        public Point 3D() : base()
        {
            z=0;
        }
        public Point 3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        public double Distance()
        {
            return 0;
        }        
    }

    class Circle
    {
        public Point Center { get; set; }
        public Point Radius { get; set; }

        public Circle()
        {
            Center = new Point();
            Radius = 0;
        }
        public Circle(int x, int y, int r)
        {
            Center = new Point(x, y);
            Radius = r;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double Square()
        {
            return Math.PI * Radius * Radius;
        }
        public double Distance(Circle c)
        {
            return Center.Distance(c.Center);
        }

    }


