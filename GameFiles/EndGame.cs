using System;
using System.Collections.Generic;

public class EndGame
{

    public void End_The_Game()
    {
        Quest myquest = new Quest();
        Console.WriteLine(myquest.Quest1);
        Console.WriteLine(myquest.Quest2);
        Console.WriteLine(myquest.Quest3);
        Console.WriteLine(myquest.Quest4);
        // List<bool> Quests = new List<bool>();
        // List<bool> QuestsNotCompleted = new List<bool>();
        List<string> QuestsNotCompleted = new List<string>();
        Dictionary<string, bool> questss = new Dictionary<string, bool>
        {
            { "Quest1", myquest.Quest1 },
            { "Quest2", myquest.Quest2 },
            { "Quest3", myquest.Quest3 },
            { "Quest4", myquest.Quest4 }

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
        }
        else
        {
            Console.WriteLine("You have not completed all the quests!");
            foreach (var item in QuestsNotCompleted)
            {
                Console.WriteLine($"You have not completed {item}!");
            }
        }



    }
}