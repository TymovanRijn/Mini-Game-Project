// make an approachable main class
public class Program
{
    public Quest Farmer = new Quest(1, 5, "Wheat", "Farmer", 1);
    public Quest Fisher = new Quest(2, 5, "Fish", "Fisher", 2);
    public Quest Smith = new Quest(3, 5, "Iron", "Smith", 3);
    public Quest Villager = new Quest(4, 5, "Wood", "Villager", 4);
    // Get the info from the Farmer

    public static void Main()
    {
        while (true)
        {
            // start de game







            //Het einde, en anders ga je weer terug
            if (EndGame.End_The_Game())
            {
                break;
            }
        }
    }
}