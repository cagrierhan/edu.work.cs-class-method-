using System;

namespace class_metod.odev
{

    class Musteri
    {
        public string Name;
        public int Age;
        public string Job;
        public int Salary;
        private int stuNum;

        public int StuNum { get => stuNum; set => stuNum = value; }

        public void Bilgi()
        {
            Console.WriteLine("İsim-Soyisim : {0}", Name);
            Console.WriteLine("Yaşınız : {0}", Age);
            Console.WriteLine("İşiniz : {0}", Job);
            Console.WriteLine("Maaşınız : {0}", Salary);
            Console.WriteLine("Öğrenci Numaranız : {0}", StuNum);
        }
    }

    class islemYap
    {
        public int x;
        public int y;
        public int z;

        public void Bes()
        {
            Console.WriteLine(x % 5);
            Console.WriteLine(y % 5);
            Console.WriteLine(z % 5);
        }
    }
    class Program
    {
        static int OL(int a, int b)
        {
            return a * b;
        }
        static int OLL(int a, int b, int g)
        {
            return a * b * g;
        }

        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.Name = "Çağrı Erhan";
            M1.Age = 21;
            M1.Job = "Student";
            M1.Salary = 0;
            M1.StuNum = 221903047;

            M1.Bilgi();

            islemYap i1 = new islemYap();
            i1.x = 555;
            i1.y = 123123;
            i1.z = 141;

            i1.Bes();

            int Ol1 = OL(3, 5);
            int Ol2 = OLL(8, 10, 123);
            Console.WriteLine("First " + Ol1);
            Console.WriteLine("Second " + Ol2);

        }

    }

}
