using System;
using System.Collections.Generic;
//Door Tymo
public class EndGame
{

    public static bool End_The_Game()
    {

        Program Program = new Program();

        // Access the Farmer field using the program instance
        Quest farmerQuest = Program.Farmer;
        Quest fisherQuest = Program.Fisher;
        Quest smithQuest = Program.Smith;
        Quest villagerQuest = Program.Villager;


        List<bool> Quests = new List<bool>();
        List<string> QuestsNotCompleted = new List<string>();
        Dictionary<string, bool> questss = new Dictionary<string, bool>
        {
            { "Farmer quest", farmerQuest.Completed_Quest },
            { "Fisher quest", fisherQuest.Completed_Quest },
            { "Smith quest", smithQuest.Completed_Quest },
            { "Villager quest", villagerQuest.Completed_Quest }
        };

        foreach (var item in questss)
        {
            if (item.Value == true)
            {
                continue;
            }
            else
            {
                QuestsNotCompleted.Add(item.Key);
            }
        }
        if (QuestsNotCompleted.Count == 0)
        {
            Console.WriteLine("You have completed all the quests!");
            // end the game
            Console.WriteLine("You have won the game!");
            Console.WriteLine("Press any key to exit the game...");
            Console.ReadKey();
            Environment.Exit(0);
            return true;
        }
        else
        {
            Console.WriteLine("You have not completed all the quests!");
            foreach (var item in QuestsNotCompleted)
            {
                Console.WriteLine($"You still have to do the {item}!");

            }
            return false;
        }



    }
}