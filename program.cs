using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
            int count = 0;
            int count1 = 0;

            Console.WriteLine("Oyuna Hoş Geldin");

            while (ans != "NO")
            {
                Console.WriteLine("Birini Seç:\n1->TAŞ\n2->KAĞIT\n3->MAKAS");
                string[] choices = new string[3] { "TAŞ", "KAĞIT", "MAKAS" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                Console.WriteLine("Seçimin:");
                string user = Console.ReadLine().ToUpper();
                Console.WriteLine("Bilgisayarın:" + choices[n]);
                //Algoritma
                //Örnek Eğer Oyuncu Taşı seçtiyse ve bilgisayar makası seçtiyse console'a "Tebrikler Sen Kazandın" Yazır
                if (user == "TAŞ" && choices[n] == "MAKAS")
                {
                    Console.WriteLine("Tebrikler Sen Kazandın");
                    count += 1;
                }
                else if (user == "TAŞ" && choices[n] == "KAĞIT")
                {
                    Console.WriteLine("Bilgisayar Kazandı");
                    count1 += 1;
                }
                else if (user == "KAĞIT" && choices[n] == "TAŞ")
                {
                    Console.WriteLine("Tebrikler Sen Kazandın");
                    count += 1;
                }
                else if (user == "KAĞIT" && choices[n] == "MAKAS")
                {
                    Console.WriteLine("Bilgisayar Kazandı");
                    count1 += 1;
                }
                else if (user == "MAKAS" && choices[n] == "TAŞ")
                {
                    Console.WriteLine("Bilgisayar Kazandı");
                    count1 += 1;
                }
                else if (user == "MAKAS" && choices[n] == "KAĞIT")
                {
                    Console.WriteLine("Tebrikler Sen Kazandın");
                    count += 1;
                }
                
                Console.WriteLine("Tekrar Oynamak İster misin?(EVET/HAYIR):");
                ans = Console.ReadLine().ToUpper();
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("Tebrikler Sen Kazandın " + count + " times");
            Console.WriteLine("Bilgisayar Kazandı " + count1 + " times");
        }
    }
}
