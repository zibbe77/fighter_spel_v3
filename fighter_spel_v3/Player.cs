using System;

public class Player : Fighter
{
    int money = 0;
    public Player()
    {
        maxHp = 20;
        maxBaseArmor = 10;
        maxBaseShield = 5;

        HpReset();
        ShieldReset();
        ArmorReset();

        baseDmg = 15;
        speed = 10;

        weapon = new Sword();

        // sätter namn på spelaren 
        string text = "Skriv namnet på din charatär. Bara bokstäver";
        Display.Line(text, 0);

        while (name == "")
        {
            string value = Console.ReadLine();

            if (value != "" && value.All(char.IsLetter))
            {
                name = value;
            }
            else
            {
                Display.Line(text, 0);
            }
        }
    }

    //attack metod 
    public override void Attack(Fighter target)
    {
        Random generator = new Random();
        int r = generator.Next(weapon.minDamage, weapon.maxDamage);
        int dmg = baseDmg + r;

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

    // återställer hp 
    public void HpReset()
    {
        hp = maxHp;
    }
    // återställer armor 
    public void ArmorReset()
    {
        baseArmor = maxBaseArmor;
    }
    // åtterställer shield 
    public void ShieldReset()
    {
        baseShield = maxBaseShield;
    }
}
