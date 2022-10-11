using System;
public class Shop
{
    public static void Shoping(Player p)
    {
        Sword sword = new Sword();
        LongSword lSword = new LongSword();

        List<Weapon> weapons = new List<Weapon>();
        weapons.Add(lSword);
        weapons.Add(sword);

        WeaponListDisplay(weapons, p);

        // kolar svaret
        bool noAnswer = true;
        while (noAnswer == true)
        {
            string input = Console.ReadLine();
            Console.Clear();
            input.ToLower();

            foreach (Weapon w in weapons)
            {
                if (input == w.Name.ToLower())
                {
                    if (p.money > w.Cost)
                    {
                        p.weapon = w;
                        noAnswer = false;
                        p.money -= w.Cost;

                        Console.Clear();
                        Display.Line($"Du fick {w.Name}", 1);
                        Display.Line($"Du har {p.money} pengar", 0);
                        Display.Enter();
                    }
                    else
                    {
                        noAnswer = false;
                        Display.Line("Du har inte nog pengar", 1);
                        Display.Line($"Du har {p.money} pengar", 1);
                        Display.Line($"Det kostar {w.Cost} pengar", 0);
                        Display.Enter();
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

            }
            if (input == "tillbaka")
            {
                noAnswer = false;
            }

            if (noAnswer == true)
            {
                string text = "Fel skriv någon av valen";
                WeaponListDisplay(weapons, p);
                Display.Line(text, 0);
            }
        }
    }

    // skriver utt information av shopen till spelaren 
    public static void WeaponListDisplay(List<Weapon> weapons, Player p)
    {
        //skriver utt dmg och namn på vad du kan köpa
        Display.Line("Vapen du kan köpa", 1);
        Display.Line($"Du har {p.money}", 1);

        foreach (Weapon w in weapons)
        {
            System.Console.WriteLine("----------------------------------------------------");
            System.Console.WriteLine(w.Name);
            System.Console.WriteLine($"{w.MinDamage} minmum {w.MaxDamage} maximum dmg - kostar {w.Cost}");
        }
        System.Console.WriteLine("----------------------------------------------------");
        System.Console.WriteLine("tillbaka");
        System.Console.WriteLine("----------------------------------------------------");
    }
}


