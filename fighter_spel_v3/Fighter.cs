using System;

public class Fighter
{
    public int Hp { get; set; }
    public int BaseArmor { get; set; }
    public int BaseShield { get; set; }

    public int MaxHp { get; set; }
    public int MaxBaseArmor { get; set; }
    public int MaxBaseShield { get; set; }

    public int BaseDmg { get; set; }
    public int Speed { get; set; }

    public string Name { get; set; }
    public bool IsAlive { get; set; }

    public Weapon weapon;

    public Fighter()
    {
        Name = "";
        IsAlive = true;
    }

    public virtual void Attack(Fighter target)
    {

    }

    public void IsItAlive()
    {
        if (Hp == 0)
        {
            IsAlive = false;
        }
    }
}

