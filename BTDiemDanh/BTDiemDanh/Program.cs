using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDiemDanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a259 = Int32.Parse(Console.ReadLine());
            double b259 = Int32.Parse(Console.ReadLine());
            double c259 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a259, b259, c259);

            double delta = pt.delta1(a259, b259, c259);
            int check259 = pt.nghiem(delta);
            if (check259 < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (check259 == 0)
            {
                double x = -b259 / (2 * a259);
                Console.WriteLine("pt co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b259 - Math.Sqrt(delta)) / (2 * a259);
                double x2 = (-b259 + Math.Sqrt(delta)) / (2 * a259);

                Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }
        }
    }

    class ptb2
    {
        private double a259;
        private double b259;
        private double c259;

        public ptb2()
        {
        }

        public ptb2(double a259, double b259, double c259)
        {
            A = a259;
            B = b259;
            C = c259;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta1(double a259, double b259, double c259)
        {
            return b259 * b259 - 4 * a259 * c259;
        }

        public int nghiem(double delta259)
        {
            if (delta259 < 0)
            {
                return -1;
            }
            else if (delta259 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
