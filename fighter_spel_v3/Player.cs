using System;

public class Player : Fighter
{
    public int money = 0;
    public Player()
    {
        MaxHp = 20;
        MaxBaseArmor = 10;
        MaxBaseShield = 5;

        HpReset();
        ShieldReset();
        ArmorReset();

        BaseDmg = 15;
        Speed = 10;

        weapon = new Sword();

        // sätter namn på spelaren 
        string text = "Skriv namnet på din charatär. Bara bokstäver";
        Display.Line(text, 0);

        while (Name == "")
        {
            string value = Console.ReadLine();

            if (value != "" && value.All(char.IsLetter))
            {
                Name = value;
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
        int r = generator.Next(weapon.MinDamage, weapon.MaxDamage);
        int dmg = BaseDmg + r;

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

    // återställer hp 
    public void HpReset()
    {
        Hp = MaxHp;
    }
    // återställer armor 
    public void ArmorReset()
    {
        BaseArmor = MaxBaseArmor;
    }
    // åtterställer shield 
    public void ShieldReset()
    {
        BaseShield = MaxBaseShield;
    }
}
