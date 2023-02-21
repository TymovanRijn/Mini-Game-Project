using System;


namespace playerMovement
{ 
 public class Movement
{
    static string player_pos = "H";
    static string player_movement = "";
    public static void position()
    {
        if (player_movement == "up")
        {
            if (player_pos = "H")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Towns Square");
                player_pos = "T";

            }
            else if (player_pos == "T")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Alchemist’s hut");
                player_pos = "A";
            }
            else if (player_pos == "A")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Alchemist’s hut");
                player_pos = "A";
            }
            else if (player_pos == "P")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further up");
                player_pos = "P";
            }
            else if (player_pos == "F")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further up");
                player_pos = "F";
            }
            else if (player_pos == "V")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further up");
                player_pos = "V";
            }
            else if (player_pos == "G")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further up");
                player_pos = "G";
            }
            else if (player_pos == "B")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further up");
                player_pos = "B";
            }
            else if (player_pos == "S")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further up");
                player_pos = "S";
            }
        }
        if (player_movement == "down")
        {
            if (player_pos = "H")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further down");
                player_pos = "H";

            }
            else if (player_pos == "T")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go down to the Town square");
                player_pos = "H";
            }
            else if (player_pos == "A")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Town square");
                player_pos = "T";
            }
            else if (player_pos == "P")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Alchemist’s hut");
                player_pos = "A";
            }
            else if (player_pos == "F")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further up");
                player_pos = "F";
            }
            else if (player_pos == "V")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further down");
                player_pos = "V";
            }
            else if (player_pos == "G")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further down");
                player_pos = "G";
            }
            else if (player_pos == "B")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further down");
                player_pos = "B";
            }
            else if (player_pos == "S")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further down");
                player_pos = "S";
            }
        }
        if (player_movement == "left")
        {
            if (player_pos = "H")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further left");
                player_pos = "H";

            }
            else if (player_pos == "T")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Farmer");
                player_pos = "F";
            }
            else if (player_pos == "F")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Farmer’s field");
                player_pos = "V";
            }
            else if (player_pos == "V")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further left");
                player_pos = "V";
            }

            else if (player_pos == "G")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Town square");
                player_pos = "T";
            }
            else if (player_pos == "B")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Guard post");
                player_pos = "G";
            }
            else if (player_pos == "S")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Bridge");
                player_pos = "B";
            }
            else if (player_pos == "A")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further left");
                player_pos = "A";
            }
            else if (player_pos == "P")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further left");
                player_pos = "P";
            }
        }
        if (player_movement == "right")
        {
            if (player_pos = "H")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further right");
                player_pos = "H";

            }
            else if (player_pos == "T")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Guard post");
                player_pos = "G";
            }
            else if (player_pos == "G")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Bridge");
                player_pos = "B";
            }
            else if (player_pos == "B")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the spider forest");
                player_pos = "S";
            }

            else if (player_pos == "V")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Farmer");
                player_pos = "F";
            }
            else if (player_pos == "F")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You will now go to the Towns square");
                player_pos = "T";
            }
            else if (player_pos == "S")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further right");
                player_pos = "S";
            }
            else if (player_pos == "A")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further right");
                player_pos = "A";
            }
            else if (player_pos == "P")
            {
                Console.WriteLine("You are at " + player_pos);
                Console.WriteLine("You can't go further right");
                player_pos = "P";
            }
        }
    }

    public static void Up()
    {
        player_movement = "up"
     position();
    }
    public static void Down()
    {
        player_movement = "down"
     position();
    }
    public static void Left()
    {
        player_movement = "left"
     position();
    }
    public static void Right()
    {
        player_movement = "right"
     position();
    }
}
 public static void Main()
 {
    if (Console.ReadKey().Key == ConsoleKey.W)
    {
        Movement.Up()
        };
    if (Console.ReadKey().Key == ConsoleKey.A)
    {
        Movement.Left()
        };
    if (Console.ReadKey().Key == ConsoleKey.D)
    {
        Movement.Right()
          };
    if (Console.ReadKey().Key == ConsoleKey.S)
    {
        Movement.Down()
          };

}
}