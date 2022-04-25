using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcoban
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("200 bai code thieu nhi :D\n");
            Console.Write("----------------------\n");
            Console.WriteLine("Bai 1: Tinh the tich hinh cau");
            Console.WriteLine("Bai 2: Tinh khoang cach cua 2 diem trong khong gian");
            Console.WriteLine("Bai 3: Tinh dien tich tam giac");
            Console.WriteLine("Bai 4: Giải phương trình bậc 1: ax + b = 0(a, bnhập từ bàn phím). ");
            Console.WriteLine("Bai 5: Viết chương trình giải hệ phương trình 2 ẩn:");
            Console.WriteLine("Bai 6: Tìm xem ngày đó là ngày thứ bao nhiêu trong năm.");
            Console.WriteLine("Bai 7: xuất ra số tương đương tính theo tuần, theo ngày và theo giờ.");
            Console.WriteLine("Bai 8: Tìm các số hoàn hảo (perfect number) nhỏ hơn một số nguyên dương ncho trước");
            Console.WriteLine("Bai 9: Tính ước số chung lớn nhất và bội số chung nhỏ nhất của a, b");
            Console.WriteLine("Bai 10: Bang cuu chuong (Multiplication table");

            double n262 = double.Parse(Console.ReadLine());
            switch (n262)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Bai 1:\n ");
                    vCau();

                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Bai 2:\n");
                    distance();
                    break;
                case 3:

                    Console.Clear();
                    Console.Write("Bai 3:\n");
                    sTriangle();
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Bai 4: \n");
                    equationOfDegree1();
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Bai 5: \n");
                    hidden();
                    break;
                case 6:
                    Console.Clear();
                    Console.Write("Bai 6: \n");
                    orderDayOnYear();
                    break;
                case 7:
                    Console.Clear();
                    Console.Write("Bai 7: \n");
                    countWDH();
                    break;
                case 8:
                    Console.Clear();
                    Console.Write("Bai 8: \n");
                    perfectNumber();

                    break;
                case 9:
                    Console.Clear();
                    Console.Write("Bai 9: \n");
                    gCD_lCM();

                    break;
                case 10:
                    Console.Clear();
                    Console.Write("Bai 10: \n");
                    multiplicationTable();
                    break;



            }
            Console.ReadKey();
        }
        static void vCau()
        {
            double v, s, pi, r;
            pi = 3.141593;
            Console.Write("Nhap vao Dien tich mat cau: ");
            s = double.Parse(Console.ReadLine());
            r = Math.Sqrt(s / (4 * pi));
            v = 1.33333 * pi * r * r * r;
            Console.WriteLine("The tich hinh cau la: " + Math.Round(v, 2) + " \n ban kinh la: " + Math.Round(r, 2));
        }
        static void distance()
        {
            Console.Write("Ax: ");
            double aX = double.Parse(Console.ReadLine());
            Console.Write("Ay: ");
            double aY = double.Parse(Console.ReadLine());
            Console.Write("Bx: ");
            double bX = double.Parse(Console.ReadLine());
            Console.Write("By: ");
            double bY = double.Parse(Console.ReadLine());

            double d;
            d = Math.Sqrt((bX - aX) * (bX - aX) + (bY - aY) * (bY - aY));
            Console.WriteLine("Khoang canh doan thang AB : " + Math.Round(d, 4));

        }
        static void sTriangle()
        {
            double s, p;
            Console.Write("Nhap vao canh a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh c:");
            double c = double.Parse(Console.ReadLine());

            if (a + b < c || a + c < b || b + c < a)
            {
                //la tam giac
                Console.WriteLine("day khong phai la tam giac ");
            }
            else if (a == b && b == c)
            {
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                //tam giac deu
                Console.WriteLine(" tam giac deu");
                Console.WriteLine("dien tich tam giac deu la: " + Math.Round(s, 4));
            }
            else if (a == b || a == c || b == c) // 2 canh bat ky bang nhau
            {
                // tam giac can
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("tam giac can");
                Console.WriteLine("dien tich tam giac can la: " + Math.Round(s, 4));
            }
            else if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b) // 2 canh bat ky bang nha
            {
                // tam vuong
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("tam giac vuong");
                Console.WriteLine("dien tich tam giac vuong la: " + Math.Round(s, 4));
            }
            else
            {
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("dien tich tam giac la: " + Math.Round(s, 4));
            }
        }
        static void equationOfDegree1()
        {
            string strA, strB;
            int a, b;
            double nghiem;
            Console.WriteLine("nhap a: ");
            strA = Console.ReadLine();
            Console.WriteLine("nhap b: ");
            strB = Console.ReadLine();
            if (int.TryParse(strA, out a) == false || int.TryParse(strB, out b) == false) // kiem tra nguoi dung co nhap so hay ko
            {
                Console.WriteLine("Du lieu nhap sai!!!");
                return; // lenh nay se duoc hieu la chuong trinh dung lai ma khong thuc hien nhung cau lenh sau do nua

            }
            else
            {
                Console.WriteLine("chuong trinh cua ban vua nhan 2 gia tri: {0}x + {1} = 0", a, b);
                if (a == 0)
                {
                    Console.WriteLine("phuong trinh vo so nghiem");

                }
                else if (b == 0)
                {
                    Console.WriteLine("phuong trinh co nghiem x = 0");

                }
                else
                {
                    nghiem = (double)b / a;// ep kieu de cho ket qua chinh xat;
                    Console.WriteLine("phuong trinh co nghiem x = " + nghiem);

                }
            }
        }
        static void hidden()
        {
            double a1, b1, c1, a2, b2, c2, dx, dy, d, x, y;
            Console.Write("a1: ");
            a1 = double.Parse(Console.ReadLine());
            Console.Write("b1: ");
            b1 = double.Parse(Console.ReadLine());
            Console.Write("c1: ");
            c1 = double.Parse(Console.ReadLine());
            Console.Write("a2: ");
            a2 = double.Parse(Console.ReadLine());
            Console.Write("b2: ");
            b2 = double.Parse(Console.ReadLine());
            Console.Write("c2: ");
            c2 = double.Parse(Console.ReadLine());
            d = (a1 * b2 - a2 * b1);
            dx = (c1 * b2 - c2 * b1);
            dy = (a1 * c2 - a2 * c1);
            if (d != 0)
            {
                x = dx / d;
                y = dy / d;
                Console.WriteLine("Hai nghiem cua he phuong trinh la :x = {0}, y = {1} ", x, y);

            }
        }
        static void orderDayOnYear()
        {
            int d, m, y, s, i;
            Console.Write("Nhap ngay: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            y = int.Parse(Console.ReadLine());
            s = d;
            for (i = 1; i < m; ++i)
            {
                switch (i)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        s += 30;
                        Console.WriteLine("Ngay thu: " + s);
                        break;
                    case 2:
                        s += (int)30.42 * (m - 1) + d;
                        Console.WriteLine("Ngay thu: " + s);
                        break;
                    default:
                        s += 31;
                        Console.WriteLine("Ngay thu: " + s);
                        break;
                }
            }
        }
        static void countWDH()
        {
            int w, d, h;
            Console.WriteLine("Nhap vao so gio: ");
            h = int.Parse(Console.ReadLine());
            w = h / (24 * 7);
            d = (h % (24 * 7)) / 24;
            h = (h % (24 * 7)) % 24;
            Console.WriteLine("w:  " + w + " d: " + d + " h: " + h);
        }
        static void perfectNumber()
        {
            int n, i, j, sum;
            Console.WriteLine("Nhap so khoan can tim: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac so hoan hao nho hon {0} la:  ", n);
            for (i = 1; i < n; ++i)
            {
                for (sum = 0, j = 1; sum <= i && j < i; ++j)
                    if (i % j == 0) sum += j;
                if (sum == i)
                    Console.Write(" {0}", i);
            }
        }
        static void gCD_lCM()
        {
            int a, b, gcd, lcm;//Greatest Common Divisor(gcd) uoc so chung lon nhat
            // Least Common Multiple (lcm) boi so chung nho nhat
            Console.WriteLine("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            gcd = a;
            while (a % gcd != 0 || b % gcd != 0)
                gcd--;
            Console.WriteLine("USCLN cua {0} va {1} la: {2}", a, b, gcd);
            lcm = a;
            while (lcm % a != 0 || lcm % b != 0) lcm++;
            Console.WriteLine("BSCNN cua {0} va {1} la: {2}", a, b, lcm);
        }
        static void multiplicationTable()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("------------");
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} x {1} = " + i * j, i, j);
                }

            }

        }
    }
}
