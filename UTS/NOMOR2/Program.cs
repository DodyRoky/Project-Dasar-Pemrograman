using System;

namespace Utsnomor2
{
    class Pemrograman
    {
        static void Main(string[] args)
        {
            Console.Clear();
            playgame();
        }
        static void playgame()
        {
            int angka;
            bool tebakan = true;
            while(tebakan)
            {
                Console.Write("Tebak angka antara 1-100 : ");
                angka = Convert.ToInt32(Console.ReadLine());
                if(angka==70)
                {
                    Console.WriteLine("Anda benar!");
                    Console.WriteLine("Bye...");
                    break;
                }
                else if(angka > 70)
                {
                    Console.WriteLine("Salah. Nilai terlalu tinggi");
                }
                else if(angka < 70)
                {
                    Console.WriteLine("Salah. Nilai terlalu kecil");
                }
            }   
        }
    }
}
    //Nama : Dody Roky Immanuel Nainggolan
    //Nim  : 2207112575
    //kelas: Teknik Informatika-A

