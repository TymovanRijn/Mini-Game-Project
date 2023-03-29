// make an approachable main class
public class Program
{



    // Get the info from the Farmer

    public static void Main()
    {
        // start de game
        //     EndGame EndGame = new EndGame();
        //     World World1 = new World();
        //     //Het einde, en anders ga je weer terug
        //     World1.clearAlchemistGarden.Completed();
        //     World1.clearFarmersField.Completed();
        //     //wait 3 seconds
        //     Thread.Sleep(3000);
        //     EndGame.End_The_Game(World1.clearAlchemistGarden, World1.clearFarmersField, World1.clearSpidersForest);

        while (true)
        {
            {
                if (Console.ReadKey().Key == ConsoleKey.W)
                {
                    MapMove.Up();
                };
                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    MapMove.Left();
                };
                if (Console.ReadKey().Key == ConsoleKey.D)
                {
                    MapMove.Right();
                };
                if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    MapMove.Down();
                };

            }
        }
    }


}