using System;


public class Logic
{
    public static void GameControler(Player p)
    {
        Display.Choice();
        ChoiceBase(p);
    }

    //hanterar valet om slås eller shop
    public static void ChoiceBase(Player p)
    {
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
                default:
                    string text = "Fel skriv någon av valen";
                    Display.Line(text, 1);
                    Display.Choice();
                    break;
            }
        }
    }
}
