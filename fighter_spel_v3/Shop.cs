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

        WeaponListDisplay(weapons);

        // kolar svaret
        bool noAnswer = true;
        while (noAnswer == true)
        {
            string input = Console.ReadLine();
            Console.Clear();
            input.ToLower();

            foreach (Weapon w in weapons)
            {
                if (p.money > 10)
                {
                    if (input == w.name.ToLower())
                    {
                        p.weapon = w;
                        noAnswer = false;
                        p.money -= 10;

                        Console.Clear();
                        Display.Line($"Du fick {w.name}", 0);
                        Display.Line($"Du har {p.money} pengar", 0);
                        Display.Enter();
                    }
                }
                else
                {
                    noAnswer = false;
                    Display.Line("Du har inte nog pengar", 0);
                    Display.Line($"Du har {p.money} pengar", 0);
                    Display.Enter();
                    Console.ReadLine();
                }
            }
            if (input == "tillbaka")
            {
                noAnswer = false;
            }

            if (noAnswer == true)
            {
                string text = "Fel skriv någon av valen";
                WeaponListDisplay(weapons);
                Display.Line(text, 0);
            }
        }
    }
    public static void WeaponListDisplay(List<Weapon> weapons)
    {
        //skriver utt dmg och namn på vad du kan köpa
        Display.Line("Vapen du kan köpa", 1);

        foreach (Weapon w in weapons)
        {
            System.Console.WriteLine("----------------------------------------------------");
            System.Console.WriteLine(w.name);
            System.Console.WriteLine($"{w.minDamage} minmum {w.maxDamage} maximum dmg");
        }
        System.Console.WriteLine("----------------------------------------------------");
        System.Console.WriteLine("tillbaka");
        System.Console.WriteLine("----------------------------------------------------");
    }
}


