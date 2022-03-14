using System;

/*struct Student
{
    public string Name;
    public int ID;
}*/

class Player
{
    //PUBLIC MEMBERS
    public string plName;
    public int baseHealth;
    public int baseArmor;
    public int baseAttack;

    //PRIVATE MEMBERS
    private int ID;

    public void SetID(int ID)
    {
        this.ID = ID;
        ID = 0;
    }

    public int GetID()
    {
        return this.ID;
    }

    public int DealDamage(Player opponent)
    {
        int damage = this.baseAttack - opponent.baseArmor;
        return damage;
    }
}

class Mage : Player
{
    void DoSomething()
    {

    }
}

class Warrior : Player
{
    void DoSomething()
    {
        this.SetID(1234);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player Chiara = new Player();
        int X = 123;
        Chiara.SetID(X);
        Console.WriteLine(X);

        Chiara.baseHealth = 10000;
        Chiara.baseAttack = 1000;

        Player Morgan = new Player();
        Morgan.baseHealth = 10000;
        Morgan.baseArmor = 100;

        Warrior George = new Warrior();

        Console.WriteLine(Morgan.baseHealth);
        int damage = Chiara.DealDamage(Morgan);
        Morgan.baseHealth -= damage;
        Console.WriteLine(Morgan.baseHealth);
    }
}