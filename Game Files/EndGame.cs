// using System;
using System.Collections.Generic;

public class EndGame
{
    public bool End_The_Game(Quest taak1, Quest taak2, Quest taak3)
    {
        World World1 = new World();

        if (taak1.Completed_Quest is true && taak2.Completed_Quest is true && taak3.Completed_Quest is true)
        {
            Console.WriteLine("You have completed the game");
            return true;
        }
        else
        {

            Console.WriteLine("You have not completed the game");
            if (taak1.Completed_Quest is false)
            {
                Console.WriteLine("You have not completed the " + taak1.quest_name + " quest");
            }
            if (taak2.Completed_Quest is false)
            {
                Console.WriteLine("You have not completed the " + taak2.quest_name + " quest");
            }
            if (taak3.Completed_Quest is false)
            {
                Console.WriteLine("You have not completed the " + taak3.quest_name + " quest");
            }
            return false;
        }
    }

}