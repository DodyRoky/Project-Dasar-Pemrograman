using System;

namespace AdventureGame 
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Selamat datang di project game Adventure");
        Console.WriteLine("Bagaimana kami harus memanggilmu?...");
        Novice Player = new Novice();
        Player.Name = Console.ReadLine().ToUpper();
        Console.WriteLine($"Selamat datang {Player.Name},Siap untuk memasuki dungeon?[Y/N]");
        var input = Console.ReadKey();
        while(true)
        {
            Console.SetCursorPosition(0,Console.CursorTop);
            if(input.Key == ConsoleKey.N || input.Key == ConsoleKey.Y)
            {
                break;
            }
            input = Console.ReadKey();
        }
        if (input.Key == ConsoleKey.N)
        {
            Console.WriteLine("Selamat Tinggal....");
            Console.ReadKey();
        }
        else
        {
            bool play = true;
            while(play)
            {
                Console.Clear();
                Console.WriteLine($"{Player.Name} memasuki dungeon....");
                Enemy enemy1 = new Enemy("Slime");
                Console.WriteLine($"{Player.Name} sedang menghadapi {enemy1.Name}");
                Console.WriteLine($"{enemy1.Name} menyerang kamu...");
                Console.WriteLine("Pilih tindakan anda");
                Console.WriteLine("1. Serangan Tunggal");
                Console.WriteLine("2. Serangan Berputar");
                Console.WriteLine("3. Memulihkan Energi");
                Console.WriteLine("4. Melarinkan Diri");

                while (!Player.IsDead && !enemy1.IsDead && !Player.IsRunningAway)
                {
                    string PlayerAction = Console.ReadLine();
                    switch (PlayerAction)
                    {
                        case "1":
                        Console.WriteLine($"{Player.Name} Melakukan Serangan Tunggal");
                        enemy1.GetHit(Player.AttackPower);
                        Player.Experience += 0.3f;
                        enemy1.Attack(enemy1.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        Console.WriteLine($"HP Pemain : {Player.Health} | HP Musuh : {enemy1.Health}\n");
                        break;
                        case "2":
                        Player.Swing();
                        Player.Experience += 0.9f;
                        if (Player.AttackPower > 0)
                        {
                            enemy1.GetHit(Player.AttackPower);
                        }
                        if (Player.SkillSlot == 0)
                        {
                            enemy1.Attack(enemy1.AttackPower);
                            Player.GetHit(enemy1.AttackPower);
                        }
                        Console.WriteLine($"HP Pemain : {Player.Health} | HP Musuh : {enemy1.Health}\n");
                        break;
                        case "3":
                        Player.ReEnergy();
                        Console.WriteLine("Energi Sedang Dipulihkan...");
                        enemy1.Attack(enemy1.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        Console.WriteLine($"HP Pemain : {Player.Health} | HP Musuh : {enemy1.Health}\n");
                        break;
                        case "4":
                        Console.WriteLine($"{Player.Name} Melarikan Diri....");
                        Player.RunningAway();
                        break;
                    }
                }
                if(enemy1.IsDead)
                {
                Console.WriteLine($"{Player.Name}Get{Player.Experience}Exp Point.");
                Console.Read();
                break;
                }
                if(Player.IsDead || Player.IsRunningAway)
                {
                    Console.Read();
                    break;
                }
            }
        }
    }  
  class Novice
  {
    public int Health { get; set; }
    public string Name { get; set; }
    public int AttackPower { get; set; }
    public int SkillSlot { get; set; }
    public bool IsDead { get; set; }
    public float Experience { get; set; }
    public bool IsRunningAway { get; set; }
    Random rnd = new Random();
    
    public Novice()
    {
        Health = 100;
        SkillSlot = 0;
        AttackPower = 1;
        IsDead = false;
        Experience = 0f;
        Name = "Pemula";
    }
    public void Swing()
    {
        if (SkillSlot > 0)
        {
            Console.WriteLine("WUSHHHHH!!!");
            AttackPower = AttackPower + rnd.Next(3, 11);
            SkillSlot--;
        }
        else
        {
            Console.WriteLine("Kamu tidak memiliki energi!");
            AttackPower = 0;
        }
    }
    public void GetHit(int hitValue)
    {
        Console.WriteLine($"{Name} Get Hit by {hitValue}");
        Health=Health-hitValue;
        if(Health <=0)
        {
            Health = 0;
            Die();
        }
    }
    public void ReEnergy()
    {
        SkillSlot   = 3;
        AttackPower = 1;
    }
    public void Die()
    {
        Console.WriteLine("You are DEAD......");
        Console.WriteLine("GAME OVER");
        IsDead = true;
    }
    public void RunningAway()
    {
        IsRunningAway = true;
    }
  }
  class Enemy
  {
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public bool IsDead { get; set; }
    Random rnd = new Random();


    public Enemy(string name)
    {
        Health = 50;
        Name = name;
    }
    public void Attack(int damage)
    {
        AttackPower = rnd.Next(1, 10);
    }
    public void GetHit(int hitValue)
    {
        Console.WriteLine($"{Name} Get Hit by {hitValue}");
        Health=Health-hitValue;

      if (Health<=0)
         {
            Health = 0;
            Die();
         }
       }
    public void Die()
       {
        Console.WriteLine($"{Name} is Dead");
        IsDead = true;
       }
    }
  }
} 
