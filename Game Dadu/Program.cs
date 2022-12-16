//Nama :Dody Roky Immanuel Nainggolan
//Kelas:Teknik Informatika
//NIM  :2207112575

using System;

namespace GameDadu
{
    class GameDadu
    {
        static void Main(string[] args)
        {
            Intro();
            PlayGame();
            Outro();

        }
        static void Intro()
        {
            Console.WriteLine("<xxxxxxxxxxxxxxxxxxxxxxxxxx[ GAME DADU ]xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx>\n");

            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Selamat datang di [ GAME DADU ]. ");
            System.Threading.Thread.Sleep(900);
            Console.Write("\b\b\b\b\\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Selamat datang di [ GAME DADU ].. ");
            System.Threading.Thread.Sleep(800);
            Console.Write("\b\b\b\b\\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Selamat datang di [ GAME DADU ]... ");
            System.Threading.Thread.Sleep(1200);
            Console.Write("\b\b\b\b\\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.WriteLine("<xxxxxxxxxxxxxxxxxxxxxxxxxx[   RULES   ]xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx>\n");
            Console.WriteLine("Pada permainan ini player akan bermain melawan komputer");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("Permainan ini terdiri dari 10 ronde");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("Setiap ronde para player dan konputer akan melempar satu buah dadu");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("Player atau Komputer dengan poin terbanyak setelah 10 ronde akan memenangkan permainan");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("---------------------------------------------------------------------------------\n");
         
        


        }
        static void PlayGame()
        {
            int daduPlayer;
            int daduKomputer;

            int jumlahRonde = 0;
            int poinKomputer = 0;
            int poinPlayer = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nTekan tombol [ ENTER ] untuk memulai...\n");
                Console.ReadKey();

                Console.WriteLine("------------------------------------------------------------------------------------");
                jumlahRonde++;
                Console.WriteLine("\n<xxxxxxxxxxxxxxxxxxxxxxxxxx[   Ronde " + jumlahRonde + "   ]xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx>\n");

                Console.Write(".");
                System.Threading.Thread.Sleep(300);
                Console.Write("\b\b");
                Console.Write("..");
                System.Threading.Thread.Sleep(300);
                Console.Write("\b\b\b");
                Console.Write("...");
                System.Threading.Thread.Sleep(300);
                Console.Write("\b\b\b\b");
                daduKomputer = numbGen();
                Console.WriteLine("Komputer melempar dadu dan mendapatkan angka " + daduKomputer + " || Tekan [ ENTER ] ");
                Console.ReadKey();
                System.Threading.Thread.Sleep(300);
                Console.Write(".");
                System.Threading.Thread.Sleep(300);
                Console.Write("\b\b");
                Console.Write("..");
                System.Threading.Thread.Sleep(300);
                Console.Write("\b\b\b");
                Console.Write("...");
                System.Threading.Thread.Sleep(300);
                Console.Write("\b\b\b\b");
                daduPlayer = numbGen();
                Console.WriteLine("Player melempar dadu dan mendapatkan angka " + daduPlayer + ".");
                System.Threading.Thread.Sleep(300);
                Console.Write(".");
                System.Threading.Thread.Sleep(300);
                Console.Write("\b\b");
                Console.Write("..");
                System.Threading.Thread.Sleep(300);
                Console.Write("\b\b\b");
                Console.Write("...");
                System.Threading.Thread.Sleep(300);
                Console.Write("\b\b\b\b");
            
                if(daduPlayer > daduKomputer)
                {
                 poinPlayer++;
                 if (jumlahRonde == 10 )
                 {
                    Console.WriteLine("\nTekan [ ENTER ] untuk melihat hasil akhir !");
                    System.Threading.Thread.Sleep(800);
                    Console.ReadKey();
                 }
                 else if (jumlahRonde < 10)
                 {
                    Console.WriteLine("Kamu Menang lanjut ronde berikutnya !");
                    System.Threading.Thread.Sleep(800);
                 }
                }
                else if (daduPlayer < daduKomputer){
                poinKomputer++;
                if (jumlahRonde == 10 )
                 { 
                    Console.WriteLine("\nTekan [ ENTER ] untuk melihat hasil akhir !");
                    System.Threading.Thread.Sleep(800);
                    Console.ReadKey();
                 }
                 else if (jumlahRonde < 10)
                 {
                    Console.WriteLine("Kamu Kalah lanjut ronde berikutnya !");
                    System.Threading.Thread.Sleep(800);  
                 }
                }
                else{
                if (jumlahRonde == 10 )
                 {  
                   Console.WriteLine("\nTekan [ ENTER ] untuk melihat hasil akhir !");
                   System.Threading.Thread.Sleep(800);
                   Console.ReadKey();
                 }
                 else if (jumlahRonde < 10)
                 {
                   Console.WriteLine("Ronde Seri lanjut ronde berikutnya !");
                   System.Threading.Thread.Sleep(800);
                 }
                }

                Console.WriteLine("Skor Player   : " + poinPlayer + ".");
                Console.WriteLine("Skor komputer : " + poinKomputer +".");
                Console.WriteLine("\n------------------------------------------------------------------------------------");
                
            }
            if (poinPlayer > poinKomputer)
            {
                Console.WriteLine("\n----------------------------------------------------------------------------");
                Console.WriteLine("Selamat,kamu memenangkan permainan ");
                Console.WriteLine("----------------------------------------------------------------------------");
            }else if (poinPlayer < poinKomputer) {
                Console.WriteLine("\n----------------------------------------------------------------------------");
                Console.WriteLine("Komputer memenangkan permainan");
                Console.WriteLine("----------------------------------------------------------------------------");
            }else {
                Console.WriteLine("\n----------------------------------------------------------------------------");
                Console.WriteLine("Permainan ini berakhir seri...");
                Console.WriteLine("----------------------------------------------------------------------------");
            }
            Console.ReadKey();
       }

       static void Outro()
       {
        Console.WriteLine("Nama  : Dody Roky Immanuel Nainggolan");
        System.Threading.Thread.Sleep(400);
        Console.WriteLine("Kelas : Teknik Informatika-A");
        System.Threading.Thread.Sleep(400);
        Console.WriteLine("Nim   : 2207112575");
        System.Threading.Thread.Sleep(400);
       }

            static int numbGen()
            {
                Random numbGen = new Random();
                int numb = numbGen.Next(1, 7);
                return numb;
            }
        }
    } 

