using System;
using playerMovement;
namespace playerMap
{ 
 public class Map
 {
    static string player_pos = "H";
    public static void getPos()
    {

    }
    public static void Show()
    {

        Console.WriteLine("""
            Legend:​
            
            H: Your house (game start)​
            
            T: Town square​
            
            F: Farmer​
            
            V: Farmer’s field​
            
            A: Alchemist’s hut​
            
            P: Alchemist’s garden​
            
            G: Guard post​
            
            B: Bridge​
            
            S: Spider forest
            """);
        Console.WriteLine("""
              P​
            
              A​
            
            VFTGBS​
            
              H
            """);
        Console.WriteLine("""
             Current position is 
            """ + player_pos);
    }

    public static void Main()
    {
        if (Console.ReadKey().Key == ConsoleKey.M)
        {
            Map.Show();
        };

    }
 }
}