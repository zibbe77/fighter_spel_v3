using System;

public class Weapon
{
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public string Name { get; set; }
    public string Id { get; set; }
    public int Cost { get; set; }

    public Weapon()
    {
        MinDamage = 10;
        MaxDamage = 15;
        Name = "Weapon";
        Id = "Weapon";

    }
}
