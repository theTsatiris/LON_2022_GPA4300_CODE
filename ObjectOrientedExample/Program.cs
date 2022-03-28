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

    public virtual int DealDamage(Player opponent)
    {
        Console.WriteLine("base DealDamage...");
        int damage = this.baseAttack - opponent.baseArmor;
        return damage;
    }
}

class Mage : Player
{
    public int baseMagic;

    public Mage()
    {
        baseMagic = 100;
    }

    public Mage(string plName) : base(plName)
    {
        baseMagic = 100;
    }

    public override int DealDamage(Player opponent)
    {
        Console.WriteLine("Mage DealDamage...");
        int initialDamage = base.DealDamage(opponent);

        return initialDamage + baseMagic;
    }
}

class Warrior : Player
{
    public int baseRage;
    public Warrior()
    {
        baseRage = 1000;
    }

    public Warrior(string plName) : base(plName)
    {
        baseRage = 1000;
    }
}

class Program
{
    //static void Main(string[] args)
    //{
    //    Player Chiara = new Player("Chiara");
    //    /*int X = 123;
    //    Chiara.SetID(X);
    //    Console.WriteLine(X);*/
    //    /*Console.WriteLine(Chiara.GetID());*/
    //    Chiara.baseHealth = 10000;
    //    Chiara.baseAttack = 1000;

    //    Player Morgan = new Player();
    //    Morgan.plName = "Morgan";
    //    /*Console.WriteLine(Morgan.GetID());*/
    //    Morgan.baseHealth = 10000;
    //    Morgan.baseArmor = 100;


    //    Mage George = new Mage("George");
    //    Warrior Harrison = new Warrior("Harrison");

    //    FightSimulation(Chiara, Morgan);
    //    FightSimulation(Chiara, George);
    //    FightSimulation(George, Chiara);
    //    FightSimulation(Morgan, Chiara);
    //    FightSimulation(Harrison, George);


    //    //Warrior George = new Warrior();

    //    //Mage Chris = new Mage();

    //    //Console.WriteLine(Morgan.baseHealth);
    //    //int damage = Chiara.DealDamage(Morgan);
    //    //Morgan.baseHealth -= damage;
    //    //Console.WriteLine(Morgan.baseHealth);

    //    //Morgan.DealDamage(George);

    //    //Player.TOTAL_PLAYERS = 81237465;

    //}

    static void FightSimulation(Player pl1, Player pl2)
    {
        Console.WriteLine(pl1.plName + " VS " + pl2.plName);
        Console.WriteLine("START OF FIGHT!!!!!");
        Console.WriteLine("Player 1 health: " + pl1.baseHealth);
        Console.WriteLine("Player 2 health: " + pl2.baseHealth);
        Console.WriteLine("Fighting in progress...");
        pl2.baseHealth -= pl1.DealDamage(pl2);
        pl1.baseHealth -= pl2.DealDamage(pl1);
        Console.WriteLine("Player 1 health: " + pl1.baseHealth);
        Console.WriteLine("Player 2 health: " + pl2.baseHealth);
        Console.WriteLine("Fighting ended!");
        Console.WriteLine();
    }
}