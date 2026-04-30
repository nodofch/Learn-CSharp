using System;

class Program
{
    static void Main()
    {
        Hero hero1 = new Hero("Alucard", "Assassin", 100, 1);
        Hero hero2 = new Hero("Zilong", "Fighter", 150, 1);
        Hero hero3 = new Hero("Eudora", "Mage", 80, 1);

        hero1.StatusUser();
        hero2.StatusUser();
        hero3.StatusUser();
    }
}

class Hero
{
    public string? nama;
    public int health;
    public int level;
    public string? role;

    public Hero(string nama, string role, int health, int level)
    {
        this.nama = nama;
        this.role = role;
        this.health = health;
        this.level = level;
    }

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
