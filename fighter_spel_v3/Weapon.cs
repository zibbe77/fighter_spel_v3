using System;

public class Weapon
{
    public int minDamage = 50;
    public int maxDamage = 100;

    public virtual void Attack(Fighter target)
    {
        Console.WriteLine("Attack!");
    }
}
