using System;

public class Enemy : Fighter
{
    public Enemy()
    {
        hp = 20;
        baseArmor = 10;
        baseShield = 5;

        baseDmg = 15;
        speed = 10;
    }
    //attack metod 
    public override void Attack(Fighter target)
    {
        Console.WriteLine("ding!");
    }
}

