using System;
using System.Collections.Generic;
//Nama  : Dody Roky Immanuel Nainggolan
//Kelas : Teknik Informatika-A
//NIM   : 2207112575


namespace tebakkata
{
    class Program
    {
        static int kesempatan=5;
        static String katamisteri ="GAGAK";
        static List<string> listtebakan = new List<string>{};
        static void Main(string[] args)
        {
            intro();
            playgame();
            outro();
        }
        static void intro()
        {
            Console.WriteLine("selamat datang di permainan [ TEBAK KATA ] ");
            Console.WriteLine($"kamu punya {kesempatan} kesempatan untuk menebak kata misteri hari ini");
            Console.WriteLine("petunjuknya adalah kata ini merupakan nama [ BURUNG ] ");
            Console.WriteLine($"kata tersebut terdiri dari {katamisteri.Length} huruf");
            Console.WriteLine("apakah kata yang dimaksud?");
            Console.WriteLine("Tekan [ ENTER ] untuk memulai...");
            while (Console.ReadKey().Key !=ConsoleKey.Enter){}
        }
        static void playgame()
        {
            while (kesempatan>0)
            {
                Console.Write("\napa huruf tebakanmu?(pilih a - z) :");string input = Console.ReadLine().ToUpper();
                listtebakan.Add(input);
                if (jikabenar(katamisteri, listtebakan))
                {
                    Console.WriteLine("Selamat anda berhasil");
                    Console.WriteLine($"Kata misteri hari ini adalah {katamisteri}\n");
                    break;
                }
                else if (katamisteri.Contains(input))
                {
                    Console.WriteLine("Huruf itu ada didalam kata ini");
                    Console.WriteLine("Silahkan tebak huruf lainnya...");
                    Console.WriteLine(jikasalah(katamisteri, listtebakan));
                }
                else
                {
                    Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan anda tinggal {kesempatan}");
                }

                if (kesempatan==0)
                {
                    outro();
                    break;
                }
            }
        }
        static bool jikabenar(string katarahasia, List<string> list)
    {bool status = false;
        for (int i = 0; i < katarahasia.Length; i++)
        {
            string c = Convert.ToString(katarahasia[i]);
            if (list.Contains(c))
            {
                status = true;
            }
            else
            {
                return status = false;
            }
        }
        return status;
    }
        static string jikasalah(string katarahasia, List<string> list)
        {string x = "";

        for (int i = 0; i < katarahasia.Length; i++)
        {
            string c = Convert.ToString(katarahasia[i]);
            if (list.Contains(c))
            {
                x = x + c;
            }
            else
            {
                x =  x + "_";
            }
        }
            return x;
        }
        static void outro()
        {
            Console.WriteLine("Nama  : Dody Roky Immanuel Nainggolan ");
            Console.WriteLine("Kelas : Teknik Informatika-A");
            Console.WriteLine("Nim   : 2207112575 ");
            if (kesempatan == 0)
            {
            Console.WriteLine("Permainan berakhir");
            Console.WriteLine($"Kata Misteri sebenarnya adalah {katamisteri}");
            }
        }
    }
}