using System;

public class Fighter
{
    public int hp;
    public int baseArmor;
    public int baseShield;

    public int baseDmg;
    public int speed;

    public string name = "";
    public bool isAlive = true;

    public Weapon weapon;

    public virtual void Attack(Fighter target)
    {

    }

    public void IsAlive()
    {
        if (hp == 0)
        {
            isAlive = false;
        }
    }
}

