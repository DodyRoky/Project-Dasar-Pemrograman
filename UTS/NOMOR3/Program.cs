using System;

namespace utsnomor3
{
    class pemrograman 
    {
        static void Main(string[] args)
        {
            int lamaMeminjam;
            int Denda;
            int lamaMeminjam1;
            int lamaMeminjam2;
            int lamaMeminjam3;
            int Denda1;
            int Denda2;
            Console.Write("Input jumlah hari peminjaman : ");
            lamaMeminjam = Convert.ToInt32(Console.ReadLine());

            //case1
            lamaMeminjam1 = lamaMeminjam - 5;
            Denda = 10000;
            //case2
            lamaMeminjam2 = lamaMeminjam - 10;
            Denda1 = 20000;
            int Dendax = 50000;
            int denday = Denda1 * lamaMeminjam2;
            denday = denday + Dendax;
            //case3
            lamaMeminjam3 = lamaMeminjam - 30;
            Denda2 = 30000;
            int Denday = 400000;
            int dendaz = Denda2 * lamaMeminjam3;
            dendaz = dendaz + Dendax + Denday;

            if(lamaMeminjam > 5 && lamaMeminjam <= 10)
            {
                Console.Write("Total denda : Rp." + Denda * lamaMeminjam1);
            }
            else if(lamaMeminjam > 10 && lamaMeminjam <= 30)
            {
                Console.Write("Total denda : Rp." + denday);
            } 
            else if(lamaMeminjam <=5)
            {
                Console.Write("Total denda : Rp.0");
            }
            else
            {
                Console.WriteLine("keanggotaan anda dibatalkan");
                Console.Write("total denda : Rp." + dendaz);
            }        
        }
    }
}
    //Nama : Dody Roky Immanuel Nainggolan
    //Nim  : 2207112575
    //kelas: Teknik Informatika-A