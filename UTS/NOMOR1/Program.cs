using System;
    namespace utsnomor1
    {
        class Pemrograman
        {
            static void Main(string[] args)
            {
              Console.Clear();
              Console.WriteLine("Nama :     ");
              string nama = Console.ReadLine();
              Console.WriteLine("NIM :     ");
              string NIM  = Console.ReadLine();
              Console.WriteLine("Konsentrasi :");
              string Konsentrasi = Console.ReadLine();
              Console.WriteLine("|**********************|");
              Console.WriteLine("|Nama:{0,17}|", nama);
              Console.WriteLine("|{0,22}|", NIM);
              Console.WriteLine("|----------------------|");
              Console.WriteLine("|{0,22}|", Konsentrasi);
              Console.WriteLine("|**********************|");
            }
        }
    }
    //Nama : Dody Roky Immanuel Nainggolan
    //Nim  : 2207112575
    //kelas: Teknik Informatika-A