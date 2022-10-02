using System;

public class Player : Fighter
{
    public Player()
    {
        hp = 20;
        baseArmor = 10;
        baseShield = 5;

        baseDmg = 15;
        speed = 10;

        weapon = new Sword();
        // sätter namn på spelaren 
        while (name == "")
        {
            string value = Console.ReadLine();

            if (value != "" && value.All(char.IsLetter))
            {
                name = value;
            }
            else
            {
                //skriver utt att det inte är ett okej namn
            }
        }
    }

    //attack metod 
    public override void Attack(Fighter target)
    {
        Random generator = new Random();
        int r = generator.Next(weapon.minDamage, weapon.maxDamage);
        int dmg = baseDmg + r;

        target.baseShield -= dmg;
        if (target.baseShield < 0)
        {
            dmg = (int)MathF.Abs(target.baseShield);
        }


        Console.WriteLine("Swing!");
    }
}
