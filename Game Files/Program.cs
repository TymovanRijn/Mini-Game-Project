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
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:
                    MapMove.Up();
                    break;
                case ConsoleKey.A:
                    MapMove.Left();
                    break;
                case ConsoleKey.D:
                    MapMove.Right();
                    break;
                case ConsoleKey.S:
                    MapMove.Down();
                    break;
                case ConsoleKey.M:
                    Map.Show();
                    break;
            };
        }
    }
}
