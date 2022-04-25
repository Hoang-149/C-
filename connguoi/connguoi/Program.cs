using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connguoi
{
    class Program
    {
        class person
        {
            int age;
            String name;

            public person(int age, string ht)
            {
                this.age = age;
                this.name = ht;
            }
            public String dotuoi()
            {
                if (this.age >= 60)
                    return "nguoi gia";
                else
                    if (this.age >= 18)
                    return " nguoi lon";
                else
                    return "em be";
            }
            public int Age
            {
                get => age;
                set => age = value;

            }
            public String Name
            {
                get => name;
                set => name = value;
            }
        }
        static void nhaptuoi()
        {
            string ht;
            int age;
            Console.WriteLine("nhap nguoi thu nhat:");
            Console.WriteLine("Ho ten:");
            ht = Console.ReadLine();
            Console.WriteLine("Tuoi:");
            age = int.Parse(Console.ReadLine());
            person ps1 = new person(age, ht);

            Console.WriteLine("nhap nguoi thu hai:");
            Console.WriteLine("Ho ten:");
            ht = Console.ReadLine();
            Console.WriteLine("Tuoi:");
            age = int.Parse(Console.ReadLine());
            person ps2 = new person(age, ht);

            Console.WriteLine("nhap nguoi thu ba:");
            Console.WriteLine("Ho ten:");
            ht = Console.ReadLine();
            Console.WriteLine("Tuoi:");
            age = int.Parse(Console.ReadLine());
            person ps3 = new person(age, ht);

            Console.WriteLine(ps1.Name + " la " + ps1.dotuoi());
            Console.WriteLine(ps2.Name + " la " + ps2.dotuoi());
            Console.WriteLine(ps3.Name + " la " + ps3.dotuoi());

        }
        static void Main(string[] args)
        {
            nhaptuoi();
        }
    }
}
