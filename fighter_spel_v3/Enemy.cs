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

        weapon = new Sword();
    }
    //attack metod 
    //skilnaden från player är att vapen är bara hälften så bra
    public override void Attack(Fighter target)
    {
        Random generator = new Random();
        int r = generator.Next(weapon.minDamage, weapon.maxDamage);
        int dmg = baseDmg + r / 2;

        //shild
        target.baseShield -= dmg;
        if (target.baseShield <= 0)
        {
            dmg = (int)MathF.Abs(target.baseShield);
            target.baseShield = 0;
        }
        else
        {
            dmg = 0;
        }

        //armor
        target.baseArmor -= dmg;
        if (target.baseArmor <= 0)
        {
            dmg = (int)MathF.Abs(target.baseArmor);
            target.baseArmor = 0;
        }
        else
        {
            dmg = 0;
        }

        //hp
        target.hp -= dmg;
        if (target.hp <= 0)
        {
            dmg = (int)MathF.Abs(target.hp);
            target.hp = 0;
        }
        else
        {
            dmg = 0;
        }

        Console.WriteLine($"{name} attackerade {target.name}");
    }
}

