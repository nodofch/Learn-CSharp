using System;

class Hero
{
    public string? nama;
    public int health;
    public int level;
    public string? role;

    public void StatusUser()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("Nama     : " + nama);
        Console.WriteLine("Role     : " + role);
        Console.WriteLine("Health   : " + health);
        Console.WriteLine("Level    : " + level);
        Console.WriteLine("---------------------");
        Console.WriteLine(" ");
    }
}

class Program
{
    static void Main()
    {
        Hero hero1 = new Hero();
        hero1.nama = "Dante";
        hero1.role = "Vampire";
        hero1.health = 100;
        hero1.level = 50;

        Hero hero2 = new Hero();
        hero2.nama = "Thorfin";
        hero2.role = "Viking";
        hero2.health = 150;
        hero2.level = 25;

        Hero hero3 = new Hero();
        hero3.nama = "Tifanny";
        hero3.role = "Healer";
        hero3.health = 70;
        hero3.level = 30;

        Hero hero4 = new Hero();
        hero4.nama = "Jong-Hae-Song";
        hero4.role = "Archer";
        hero4.health = 85;
        hero4.level = 40;

        hero1.StatusUser();
        hero2.StatusUser();
        hero3.StatusUser();
        hero4.StatusUser();



    }
}