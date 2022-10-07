using System;


public class Logic
{
    public static void GameControler(Player p)
    {
        Display.Choice();
        ChoiceBase(p);
        p.HpReset();
        p.ShieldReset();
        p.ArmorReset();
    }

    //hanterar valet om slås eller shop
    public static void ChoiceBase(Player p)
    {
        //avslutar loopen
        bool Answer = true;

        while (Answer == true)
        {
            string input = Console.ReadLine();
            Console.Clear();
            switch (input.ToLower())
            {
                case "slåss":
                    Answer = false;
                    FightController.FightTurnController(p);
                    break;
                case "shop":
                    Answer = false;
                    Shop.Shoping(p);
                    break;
                case "livs statistik":
                    Answer = false;
                    Display.Stats(p);
                    break;
                case "läka":
                    Answer = false;
                    Heal(p);
                    break;
                default:
                    string text = "Fel skriv någon av valen";
                    Display.Line(text, 1);
                    Display.Choice();
                    break;
            }
        }
    }

    public static void Heal(Player p)
    {
        Display.Line("vill du läka dig Ja/Nej", 0);
        string input = Console.ReadLine();

        bool loop = true;
        while (loop == true)
        {
            switch (input.ToLower())
            {
                case "ja":
                    loop = false;
                    if (p.money > 5)
                    {
                        p.money -= 5;
                        p.HpReset();
                        p.ShieldReset();
                        p.ArmorReset();
                        Display.Line("Du har läka dig", 1);
                        Display.Line($"Du har {p.money} pengar", 0);
                        Display.Enter();
                        Console.ReadLine();
                    }
                    else
                    {
                        Display.Line("Du har inte nog pengar", 0);
                        Display.Line($"Du har {p.money} pengar", 0);
                        Display.Enter();
                        Console.ReadLine();
                    }
                    break;
                case "nej":
                    loop = false;
                    Display.Line("okej du läkde dig inte", 0);
                    Display.Enter();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
