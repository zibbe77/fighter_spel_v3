using System;

public class Enemy : Fighter
{
    public Enemy()
    {
        Hp = 20;
        BaseArmor = 10;
        BaseShield = 5;

        BaseDmg = 15;
        Speed = 10;

        weapon = new Sword();
    }
    //attack metod 
    //skilnaden från player är att vapen är bara hälften så bra
    public override void Attack(Fighter target)
    {
        Random generator = new Random();
        int r = generator.Next(weapon.MinDamage, weapon.MaxDamage);
        int dmg = BaseDmg + r / 2;

        //shild
        target.BaseShield -= dmg;
        if (target.BaseShield <= 0)
        {
            dmg = (int)MathF.Abs(target.BaseShield);
            target.BaseShield = 0;
        }
        else
        {
            dmg = 0;
        }

        //armor
        target.BaseArmor -= dmg;
        if (target.BaseArmor <= 0)
        {
            dmg = (int)MathF.Abs(target.BaseArmor);
            target.BaseArmor = 0;
        }
        else
        {
            dmg = 0;
        }

        //hp
        target.Hp -= dmg;
        if (target.Hp <= 0)
        {
            dmg = (int)MathF.Abs(target.Hp);
            target.Hp = 0;
        }
        else
        {
            dmg = 0;
        }

        Console.WriteLine($"{Name} attackerade {target.Name}");
    }
}

