using System;
using System.Collections.Generic;

/*struct Student
{
    public string Name;
    public int ID;
}*/

class Player
{
    public static int TOTAL_PLAYERS = 0;

    //PUBLIC MEMBERS
    public string plName;
    public int baseHealth;
    public int baseArmor;
    public int baseAttack;
    public List<int> friendIDs; 

    //PRIVATE MEMBERS
    private int ID;

    //Our own, personal default constructor
    public Player()
    {
        this.plName = "NONAME";
        this.baseHealth = 100;
        this.baseArmor = 10;
        this.baseAttack = 10;

        this.ID = TOTAL_PLAYERS++;

        this.friendIDs = new List<int>();
    }

    public Player(string plName)
    {
        this.plName = plName;
        this.baseHealth = 100;
        this.baseArmor = 10;
        this.baseAttack = 10;

        this.ID = TOTAL_PLAYERS++;

        this.friendIDs = new List<int>();
    }

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

    public int DealDamage(Warrior opponent)
    {
        return 0;
    }
}

class Mage : Player
{
    
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
        Player Chiara = new Player("Chiara");
        /*int X = 123;
        Chiara.SetID(X);
        Console.WriteLine(X);*/
        Console.WriteLine(Chiara.GetID());


        Chiara.baseHealth = 10000;
        Chiara.baseAttack = 1000;

        Player Morgan = new Player();
        Console.WriteLine(Morgan.GetID());
        Morgan.baseHealth = 10000;
        Morgan.baseArmor = 100;

        //Warrior George = new Warrior();

        //Mage Chris = new Mage();

        //Console.WriteLine(Morgan.baseHealth);
        //int damage = Chiara.DealDamage(Morgan);
        //Morgan.baseHealth -= damage;
        //Console.WriteLine(Morgan.baseHealth);

        //Morgan.DealDamage(George);

        //Player.TOTAL_PLAYERS = 81237465;

    }
}