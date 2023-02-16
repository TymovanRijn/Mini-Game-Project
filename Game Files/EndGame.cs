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
        Dictionary<string, bool> questss = new Dictionary<string, bool>
        {
            { "Quest1", myquest.Quest1 },
            { "Quest2", myquest.Quest2 },
            { "Quest3", myquest.Quest3 },
            { "Quest4", myquest.Quest4 }

        };

        foreach (bool questt in questss)
        {
            Console.WriteLine(questt);
            if (questt == false)
            {
                Console.WriteLine($"You have not completed {questt}");

            }
        }


        // if (Quest1 is true && Quest2 is true && Quest3 is true && Quest4 is true)
        // {
        //     Console.WriteLine("You have completed all the quests");
        //     Console.WriteLine("You have won the game");
        //     Console.WriteLine("Press any key to exit");
        //     Console.ReadKey();
        //     Environment.Exit(0);
        // }
        // else
        // {
        //     Console.WriteLine($"You have not completed all the quests, you still have to complete {QuestsNotCompleted}");
        // }
    }
}