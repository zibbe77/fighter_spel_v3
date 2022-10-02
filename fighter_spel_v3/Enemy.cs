using System;

public class Enemy : Fighter
{

    //attack metod 
    public override void Attack(Fighter target)
    {
        Console.WriteLine("ding!");
    }
}

