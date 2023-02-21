// public class Fight
// {
//     public string weapon = "sword";
//     public int health = 100;
//     public int spider_health = 60;
//     public int snake_health = 110;
//     public int rat_health = 80;

//     public int damage = 0;
//     //     public const int MONSTER_ID_RAT = 1;
//     //     public const int MONSTER_ID_SNAKE = 2;
//     //     public const int MONSTER_ID_GIANT_SPIDER = 3;
//     public void fight_rat()
//     {
//         while (rat_health != 0)
//         {
//             Console.WriteLine($"How would you like to attack?\nA: Kick\n B: Attack with your {weapon}\n C: Stamp");
//             string fight_choice1 = Console.ReadLine();
//             string fight_choice = fight_choice1.ToUpper();
//             switch (fight_choice)
//             {
//                 case "A":
//                     damage = 8;
//                     Console.WriteLine($"You chose to kick \n {damage} damage done");
//                     rat_health = rat_health - damage;
//                     break;
//                 case "B":
//                     damage = 15;
//                     Console.WriteLine($"You chose to Attack with your{weapon} \n {damage} damage done");
//                     rat_health = rat_health - damage;
//                     break;
//                 case "C":
//                     damage = 20;
//                     Console.WriteLine($"You chose to stamp \n {damage} damage done");
//                     rat_health = rat_health - damage;
//                     break;
//             }
//         }
//     }

//     public void fight_snake()
//     {
//         while (snake_health != 0)
//         {
//             Console.WriteLine($"How would you like to attack?\nA: Kick\n B: Attack with your {weapon}\n C: Stamp");
//             string fight_choice1 = Console.ReadLine();
//             string fight_choice = fight_choice1.ToUpper();
//             switch (fight_choice)
//             {
//                 case "A":
//                     damage = 0;
//                     Console.WriteLine($"You missed..\n {damage} damage done");
//                     snake_health = snake_health - damage;
//                     break;
//                 case "B":
//                     damage = 20;
//                     Console.WriteLine($"You chose to Attack with your{weapon} \n {damage} damage done");
//                     snake_health = snake_health - damage;
//                     break;
//                 case "C":
//                     damage = 22;
//                     Console.WriteLine($"You chose to stamp \n {damage} damage done");
//                     snake_health = snake_health - damage;
//                     break;
//             }
//         }

//     }

//     public void fight_spider()
//     {
//         while (spider_health != 0)
//         {
//             Console.WriteLine($"How would you like to attack?\nA: Kick\n B: Attack with your {weapon}\n C: Stamp");
//             string fight_choice1 = Console.ReadLine();
//             string fight_choice = fight_choice1.ToUpper();
//             switch (fight_choice)
//             {
//                 case "A":
//                     damage = 2;
//                     Console.WriteLine($"You barely hit it.. \n {damage} damage done");
//                     spider_health = spider_health - damage;
//                     break;
//                 case "B":
//                     damage = 15;
//                     Console.WriteLine($"You chose to Attack with your{weapon}. \n {damage} damage done");
//                     spider_health = spider_health - damage;
//                     break;
//                 case "C":
//                     damage = 20;
//                     Console.WriteLine($"You chose to stamp \n {damage} damage done");
//                     spider_health = spider_health - damage;
//                     break;
//             }
//         }

//     }
// }