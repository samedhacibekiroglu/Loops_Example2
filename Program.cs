using System;

namespace Loops_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            //While

            int i = 1;
            Random rdn = new Random();
            int rastgele = rdn.Next(0, 10);
            while (true)
            {
                Console.Write("Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == rastgele)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i + ". tahmininizde sayıyı buldunuz.");
            Console.ReadKey();

            //Foreach

            string[] sehirler = new string[3];
            for (int s = 0; s < sehirler.Length; s++)
            {
                Console.Write("Şehir Adını girin: ");
                sehirler[s] = Console.ReadLine();
            }

            Console.Write("Listelemek istediğiniz şehrin baş harfini girin: ");
            char harf = Convert.ToChar(Console.ReadLine());

            foreach (string sehir in sehirler)
            {

                if (sehir[0] == harf)
                {
                    Console.WriteLine(sehir);
                }
            }

            Console.ReadKey();
        }
    }
}
