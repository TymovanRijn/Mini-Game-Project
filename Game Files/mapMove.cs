public class MapMove
{
    static string player_pos = "H";
    static string player_movement = "";
    public static void position()
    {
        switch (player_movement)
        {
            case "up":
                switch (player_pos)
                {
                    case "H":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Towns Square");
                        player_pos = "T";
                        break;
                    case "T":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Alchemist’s hut");
                        player_pos = "A";
                        break;
                    case "A":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Alchemist’s hut");
                        player_pos = "A";
                        break;
                    case "P":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further up");
                        player_pos = "P";
                        break;
                    case "F":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further up");
                        player_pos = "F";
                        break;
                    case "V":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further up");
                        player_pos = "V";
                        break;
                    case "G":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further up");
                        player_pos = "G";
                        break;
                    case "B":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further up");
                        player_pos = "B";
                        break;
                    case "S":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further up");
                        player_pos = "S";
                        break;
                }
                break;
            case "down":
                switch (player_pos)
                {
                    case "H":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further down");
                        player_pos = "H";

                        break;
                    case "T":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go down to the Town square");
                        player_pos = "H";
                        break;
                    case "A":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Town square");
                        player_pos = "T";
                        break;
                    case "P":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Alchemist’s hut");
                        player_pos = "A";
                        break;
                    case "F":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further up");
                        player_pos = "F";
                        break;
                    case "V":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further down");
                        player_pos = "V";
                        break;
                    case "G":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further down");
                        player_pos = "G";
                        break;
                    case "B":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further down");
                        player_pos = "B";
                        break;
                    case "S":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further down");
                        player_pos = "S";
                        break;
                }
                break;
            case "left":
                switch (player_pos)
                {
                    case "H":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further left");
                        player_pos = "H";

                        break;
                    case "T":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Farmer");
                        player_pos = "F";
                        break;
                    case "F":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Farmer’s field");
                        player_pos = "V";
                        break;
                    case "V":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further left");
                        player_pos = "V";
                        break;
                    case "G":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Town square");
                        player_pos = "T";
                        break;
                    case "B":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Guard post");
                        player_pos = "G";
                        break;
                    case "S":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Bridge");
                        player_pos = "B";
                        break;
                    case "A":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further left");
                        player_pos = "A";
                        break;
                    case "P":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further left");
                        player_pos = "P";
                        break;
                }
                break;
            case "right":
                switch (player_pos)
                {
                    case "H":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further right");
                        player_pos = "H";

                        break;
                    case "T":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Guard post");
                        player_pos = "G";
                        break;
                    case "G":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Bridge");
                        player_pos = "B";
                        break;
                    case "B":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the spider forest");
                        player_pos = "S";
                        break;
                    case "V":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Farmer");
                        player_pos = "F";
                        break;
                    case "F":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You will now go to the Towns square");
                        player_pos = "T";
                        break;
                    case "S":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further right");
                        player_pos = "S";
                        break;
                    case "A":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further right");
                        player_pos = "A";
                        break;
                    case "P":
                        Console.WriteLine("You are at " + player_pos);
                        Console.WriteLine("You can't go further right");
                        player_pos = "P";
                        break;
                }
                break;
        }
    }

    public static void Up()
    {
        player_movement = "up";
        position();
    }
    public static void Down()
    {
        player_movement = "down";
        position();
    }
    public static void Left()
    {
        player_movement = "left";
        position();
    }
    public static void Right()
    {
        player_movement = "right";
        position();
    }

}
