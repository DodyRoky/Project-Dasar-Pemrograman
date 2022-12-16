using System;

namespace utsnomor3
{
    class program
    {
        static Random pilihan = new Random();
        static int menang;
        static int kalah;
        static int seri;
        static bool playGame;
        static void Main(string[] args)
        {
          playGame = true;
          while(playGame)
            {
                Console.Clear();
                Console.WriteLine("Batu,Gunting,Kertas");
                Console.Write("\nChoose [b]atu,[g]unting,[k]ertas,or [e]xit:");
                string pilihanAnda = Console.ReadLine();
                if(pilihanAnda == "e")
                {
                    break;
                }
                int pilihanKomputer = pilihan.Next(0,3);
                if (pilihanKomputer == 0)
                {
                    Console.WriteLine("Komputer memilih batu.");
                    switch (pilihanAnda)
                    {
                        case "b":
                        Console.WriteLine("Seri.");
                        seri++;
                        break;
                        case "g":
                        Console.WriteLine("Anda kalah.");
                        kalah++;
                        break;
                        case "k":
                        Console.WriteLine("Anda menang.");;
                        menang++;
                        break;
                    } 
                }
                else if(pilihanKomputer == 1)
                {
                    Console.WriteLine("Komputer memilih gunting.");
                    switch (pilihanAnda)
                    {
                        case "b":
                        Console.WriteLine("Anda menang.");
                        menang++;
                        break;
                        case "g":
                        Console.WriteLine("Seri.");
                        seri++;
                        break;
                        case "k":
                        Console.WriteLine("Anda kalah.");
                        kalah++;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Komputer memilih kertas.");
                    switch (pilihanAnda)
                    {
                        case "b":
                        Console.WriteLine("Anda kalah.");
                        kalah++;
                        break;
                        case "g":
                        Console.WriteLine("Anda menang.");
                        menang++;
                        break;
                        case "k":
                        Console.WriteLine("Seri.");
                        seri++;
                        break;
                    }
                }
                Console.WriteLine($"Skor: {menang} menang, {kalah} kalah, {seri} seri");
                Console.WriteLine("Tekan enter untuk melanjutkan permainan...");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                    playGame = true;
                }
            }
        }
    }
}
    //Nama : Dody Roky Immanuel Nainggolan
    //Nim  : 2207112575
    //kelas: Teknik Informatika-A