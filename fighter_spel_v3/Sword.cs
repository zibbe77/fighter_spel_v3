using System;


public class Sword : Weapon
{
    public Sword()
    {
        maxDamage = 200;
    }
    
    public override void Attack(Fighter target)
    {
        Console.WriteLine("Swing!");
    }
}
