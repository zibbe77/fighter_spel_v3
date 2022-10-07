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
            switch (input.ToLower())
            {
                case "slåss":
                    Answer = false;
                    FightController.FightTurnController(p);
                    break;
                case "shop":
                    Answer = false;

                    break;
                case "livs statistik":
                    Answer = false;

                    Display.Stats(p);
                    break;
                default:
                    string text = "Fel skriv någon av valen";
                    Display.Line(text, 1);
                    Display.Choice();
                    break;
            }
        }
    }
}
