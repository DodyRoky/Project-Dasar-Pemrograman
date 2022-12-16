using System;

namespace DasarPemrograman
{
    class Program
    {
         //main method 
        static void Main(string[] args)
        {
            int kesempatan = 3;
        
            //Invoke function/method
            intro();
            //bool bGameSelesai = PlayGame();
            while(kesempatan > 0){
                PlayGame();
                kesempatan = kesempatan - 1;
            }

        }
        static void intro(){
             //intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server..."); 
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
        }

        static void PlayGame(){
              //deklarasi variabel 
            int kodeA;
            int kodeB; 
            int kodeC;
            int jumlahKode;
            String tebakanA;
            String tebakanB;
            String tebakanC;

            int hasilTambah;
            int hasilKali; 

            //buat random number generator (rmg)
            Random rmg = new Random();

            //inisialisasi variabel
            kodeA = rmg.Next(1,3);
            kodeB = rmg.Next(1,3);
            kodeC = rmg.Next(1,3);
            
            jumlahKode = 3;

            //Operasi Aritmatika
            hasilTambah = kodeA+kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;

            //intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server..."); 
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("Jika ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("Jika dikalikan hasilnya "+hasilKali);

            //input user 
            Console.Write("Masukkan kode 1 : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukkan kode 2 : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukkan kode 3 : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan Anda :"+ tebakanA +" "+ tebakanB +" "+ tebakanC +" ?(ya/tidak?)");

            //konfirmasi
            String konfirmasi = Console.ReadLine();
            if(konfirmasi == "ya"){

                 //logic
            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
            {
                Console.WriteLine("Congratulation!");
                // return true
            }else{
                Console.WriteLine("Code is Wrong!");
                Console.WriteLine("The code is " +kodeA+" " +kodeB+" " +kodeC+".");
               // return false;
            }   
         }else{
           // Playgame();
            }
        }
    }
}

