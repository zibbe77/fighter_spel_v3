using System;

public class Fighter
{
    public int hp;
    public int baseArmor;
    public int baseShield;

    public int baseDmg;
    public int speed;

    public string name = "";

    public Weapon weapon;

    public virtual void Attack(Fighter target)
    {

    }
}
