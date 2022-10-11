using System;


public class Sword : Weapon
{
    public Sword()
    {
        Cost = 20;
        MaxDamage = 20;
        Name = "Sword";
        Id = "Sword";
    }

    // public override void Attack(Fighter target)
    // {
    //     Console.WriteLine("Swing!");
    // }
}
