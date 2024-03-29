public class World
{
    public Quest clearAlchemistGarden =
           new Quest(
                "Clear the alchemist's garden",
               1,
               3,
               "Rat tails",
               "Alchemist",
                1);

    public Quest clearFarmersField =
       new Quest(
              "Clear the farmer's field",
          2,
           3,
           "Snake Fangs",
           "Farmer",
            2);

    public Quest clearSpidersForest =
        new Quest(
            "Clear the spiders' forest",
            3,
            3,
            "Spider silk",
            "Guard",
            3);
}
// {
//     public static readonly List<Item> Items = new List<Item>();
//     public static readonly List<Weapon> Weapons = new List<Weapon>();
//     public static readonly List<Monster> Monsters = new List<Monster>();
//     public static readonly List<Quest> Quests = new List<Quest>();
//     public static readonly List<Location> Locations = new List<Location>();
//     public static readonly Random RandomGenerator = new Random();

//     public const int WEAPON_ID_RUSTY_SWORD = 1;
//     public const int WEAPON_ID_CLUB = 2;

//     public const int ITEM_ID_RAT_TAIL = 1;
//     public const int ITEM_ID_PIECE_OF_FUR = 2;
//     public const int ITEM_ID_SNAKE_FANG = 3;
//     public const int ITEM_ID_SNAKESKIN = 4;
//     public const int ITEM_ID_SPIDER_FANG = 5;
//     public const int ITEM_ID_SPIDER_SILK = 6;
//     public static bool ADVENTURER_PASS = false;
//     public const int ITEM_ID_WINNERS_MEDAL = 8;

//     public const int MONSTER_ID_RAT = 1;
//     public const int MONSTER_ID_SNAKE = 2;
//     public const int MONSTER_ID_GIANT_SPIDER = 3;

//     public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
//     public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
//     public const int QUEST_ID_COLLECT_SPIDER_SILK = 3;

//     public const int LOCATION_ID_HOME = 1;
//     public const int LOCATION_ID_TOWN_SQUARE = 2;
//     public const int LOCATION_ID_GUARD_POST = 3;
//     public const int LOCATION_ID_ALCHEMIST_HUT = 4;
//     public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
//     public const int LOCATION_ID_FARMHOUSE = 6;
//     public const int LOCATION_ID_FARM_FIELD = 7;
//     public const int LOCATION_ID_BRIDGE = 8;
//     public const int LOCATION_ID_SPIDER_FIELD = 9;



//     public static void PopulateItems()
//     {
//         Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails"));
//         Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
//         Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs"));
//         Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins"));
//         Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs"));
//         Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
//         Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes"));
//         Items.Add(new Item(ITEM_ID_WINNERS_MEDAL, "Winner's medal", "winner's medals"));
//     }

//     // public static void PopulateWeapons()
//     // {
//     //     Weapons.Add(new Weapon(WEAPON_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));
//     //     Weapons.Add(new Weapon(WEAPON_ID_CLUB, "Club", "Clubs", 3, 10));
//     // }

//     // public static void PopulateMonsters()
//     // {
//     //     Monster rat = new Monster(MONSTER_ID_RAT, "rat", "rats", 5, 3, 10, 3, 3);
//     //     rat.Loot.AddItem(ItemByID(ITEM_ID_RAT_TAIL));
//     //     rat.Loot.AddItem(ItemByID(ITEM_ID_PIECE_OF_FUR));

//     //     Monster snake = new Monster(MONSTER_ID_SNAKE, "snake", "snakes", 5, 4, 20, 7, 7);
//     //     snake.Loot.AddItem(ItemByID(ITEM_ID_SNAKE_FANG));
//     //     snake.Loot.AddItem(ItemByID(ITEM_ID_SNAKESKIN));

//     //     Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "giant spider", "giant spiders", 5, 5, 30, 10, 10);
//     //     giantSpider.Loot.AddItem(ItemByID(ITEM_ID_SPIDER_FANG));
//     //     giantSpider.Loot.AddItem(ItemByID(ITEM_ID_SPIDER_SILK));

//     //     Monsters.Add(rat);
//     //     Monsters.Add(snake);
//     //     Monsters.Add(giantSpider);
//     // }

//     public void PopulateQuests()
//     {
//         Quest clearAlchemistGarden =
//            new Quest(
//                QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
//                3,
//                "Rat tails",
//                "Alchemist",
//                 1);

//         Quest clearFarmersField =
//            new Quest(
//                QUEST_ID_CLEAR_FARMERS_FIELD,
//                3,
//                "Snake Fangs",
//                "Farmer",
//                 2);

//         Quest clearSpidersForest =
//             new Quest(
//                 QUEST_ID_COLLECT_SPIDER_SILK,
//                 3,
//                 "Spider silk",
//                 "Guard",
//                 3);

//         Quests.Add(clearAlchemistGarden);
//         Quests.Add(clearFarmersField);
//         Quests.Add(clearSpidersForest);
//     }


//     public static void NPC_Alchemist()
//     {
//         foreach (Quest i in Quests)
//         {
//             if (i.Quest_ID == 2)
//             {
//                 if ((i.Completed_Quest is false) && (i.Active_Quest is false))
//                 {
//                     Console.WriteLine("Adventure my garden is infested with rats can you help me? (y/n)");
//                     string Awnser = Console.ReadLine();
//                     Awnser.ToLower();
//                     if (Awnser == "y")
//                     {
//                         Console.WriteLine("Can you get me 3 rat tails as proof that my garden is safe again.");
//                     }
//                     else if (Awnser == "n")
//                     {
//                         Console.WriteLine("Come back when you have changed your mind!.");
//                     }
//                 }
//                 else if ((i.Completed_Quest is false) && (i.Active_Quest is true))
//                 {
//                     Console.WriteLine($"Adventure have you collected {i.Total_Item} rat tails? (y/n)");
//                     string Awnser = Console.ReadLine();
//                     Awnser.ToLower();
//                     if ((Awnser == "y") && (i.Found_Item >= i.Total_Item))
//                     {
//                         Console.WriteLine("Thankyou adventure for helping me here an club pass as a thankyou.");
//                         i.Completed();
//                     }
//                     if ((Awnser == "y") && (i.Found_Item < i.Total_Item))
//                     {
//                         Console.WriteLine($"Liar you have {i.Found_Item}/{i.Total_Item} collected. \nNow you need to get 1 more!");
//                         i.Total_Item += 1;
//                     }
//                     else if (Awnser == "n")
//                     {
//                         Console.WriteLine("Come back when you have more.");
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Adventure my garden is safe now. Have a nice day!");
//                 }
//             }
//         }

//     }

//     public static void NPC_Farmer()
//     {
//         foreach (Quest i in Quests)
//         {
//             if (i.Quest_ID == 1)
//             {
//                 if ((i.Completed_Quest is false) && (i.Active_Quest is false))
//                 {
//                     Console.WriteLine("Adventure i hava a problem with snakes in my field can you help me? (y/n)");
//                     string Awnser = Console.ReadLine();
//                     Awnser.ToLower();
//                     if (Awnser == "y")
//                     {
//                         Console.WriteLine("Can you get me 3 snake fangs as proof that my field is safe again.");
//                     }
//                     else if (Awnser == "n")
//                     {
//                         Console.WriteLine("Come back when you have changed your mind!.");
//                     }
//                 }
//                 else if ((i.Completed_Quest is false) && (i.Active_Quest is true))
//                 {
//                     Console.WriteLine($"Adventure have you collected {i.Total_Item} snake fangs? (y/n)");
//                     string Awnser = Console.ReadLine();
//                     Awnser.ToLower();
//                     if ((Awnser == "y") && (i.Found_Item >= i.Total_Item))
//                     {
//                         Console.WriteLine("Thankyou adventure for helping me here an adventure's pass as a thankyou.");
//                         i.Completed();
//                         ADVENTURER_PASS = true;
//                     }
//                     if ((Awnser == "y") && (i.Found_Item >= i.Total_Item))
//                     {
//                         Console.WriteLine($"Liar you have {i.Found_Item}/{i.Total_Item} collected. \nNow you need to get 1 more!");
//                         i.Total_Item += 1;
//                     }
//                     else if (Awnser == "n")
//                     {
//                         Console.WriteLine("Come back when you have more.");
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Adventure my field is safe now. Have a nice day!");
//                 }
//             }
//         }
//     }


//     public static void NPC_Guard()
//     {
//         foreach (Quest i in Quests)
//         {
//             if (i.Quest_ID == 3)
//             {
//                 if ((i.Completed_Quest is false) && (i.Active_Quest is false))
//                 {
//                     Console.WriteLine("Adventure there is a spider problem in the forest can you fix it? (y/n)");
//                     string Awnser = Console.ReadLine();
//                     Awnser.ToLower();
//                     if (Awnser == "y")
//                     {
//                         Console.WriteLine("Collect 3 spider silk.");
//                     }
//                     else if (Awnser == "n")
//                     {
//                         Console.WriteLine("Come back when you have changed your mind!.");
//                     }
//                 }
//                 else if ((i.Completed_Quest is false) && (i.Active_Quest is true))
//                 {
//                     Console.WriteLine($"Adventure have you collected {i.Total_Item} spider silk? (y/n)");
//                     string Awnser = Console.ReadLine();
//                     Awnser = Awnser.ToLower();
//                     if ((Awnser == "y") && (i.Found_Item >= i.Total_Item))
//                     {
//                         Console.WriteLine("Because you cleared the forest adventure i shall award you the winner's medal.");
//                         i.Completed();
//                     }
//                     else if ((Awnser == "y") && (i.Found_Item >= i.Total_Item))
//                     {
//                         Console.WriteLine($"Liar you have {i.Found_Item}/{i.Total_Item} collected. \nNow you need to get 1 more!");
//                         i.Total_Item += 1;
//                     }
//                     else if (Awnser == "n")
//                     {
//                         Console.WriteLine("Come back when you have more.");
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Adventure the forest is safe again thankyou!");
//                 }
//             }
//         }
//     }
//     public static void PopulateLocations()
//     {
//         // Create each location
//         Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.", null, null, null);

//         Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.", null, null, null);

//         Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.", null, null, null);
//         alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

//         Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.", null, null, null);
//         alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

//         Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.", null, null, null);
//         farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

//         Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.", null, null, null);
//         farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

//         Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", ItemByID(ITEM_ID_ADVENTURER_PASS), null, null);

//         Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.", null, null, null);
//         bridge.QuestAvailableHere = QuestByID(QUEST_ID_COLLECT_SPIDER_SILK);

//         Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.", null, null, null);
//         spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

//         // Link the locations together
//         home.LocationToNorth = townSquare;

//         townSquare.LocationToNorth = alchemistHut;
//         townSquare.LocationToSouth = home;
//         townSquare.LocationToEast = guardPost;
//         townSquare.LocationToWest = farmhouse;

//         farmhouse.LocationToEast = townSquare;
//         farmhouse.LocationToWest = farmersField;

//         farmersField.LocationToEast = farmhouse;

//         alchemistHut.LocationToSouth = townSquare;
//         alchemistHut.LocationToNorth = alchemistsGarden;

//         alchemistsGarden.LocationToSouth = alchemistHut;

//         guardPost.LocationToEast = bridge;
//         guardPost.LocationToWest = townSquare;

//         bridge.LocationToWest = guardPost;
//         bridge.LocationToEast = spiderField;

//         spiderField.LocationToWest = bridge;

//         // Add the locations to the static list
//         Locations.Add(home);
//         Locations.Add(townSquare);
//         Locations.Add(guardPost);
//         Locations.Add(alchemistHut);
//         Locations.Add(alchemistsGarden);
//         Locations.Add(farmhouse);
//         Locations.Add(farmersField);
//         Locations.Add(bridge);
//         Locations.Add(spiderField);
//     }

//     public static Location LocationByID(int id)
//     {
//         foreach (Location location in Locations)
//         {
//             if (location.ID == id)
//             {
//                 return location;
//             }
//         }

//         return null;
//     }

//     public static Weapon WeaponByID(int id)
//     {
//         foreach (Weapon item in Weapons)
//         {
//             if (item.ID == id)
//             {
//                 return item;
//             }
//         }

//         return null;
//     }

//     public static Item ItemByID(int id)
//     {
//         foreach (Item item in Items)
//         {
//             if (item.ID == id)
//             {
//                 return item;
//             }
//         }

//         return null;
//     }

//     public static Monster MonsterByID(int id)
//     {
//         foreach (Monster monster in Monsters)
//         {
//             if (monster.ID == id)
//             {
//                 return monster;
//             }
//         }

//         return null;
//     }

//     public static Quest QuestByID(int id)
//     {
//         foreach (Quest quest in Quests)
//         {
//             if (quest.ID == id)
//             {
//                 return quest;
//             }
//         }

//         return null;
//     }
//     static void World()
//     {
//         PopulateItems();
//         // PopulateWeapons();
//         // PopulateMonsters();
//         PopulateQuests();
//         PopulateLocations();
//     }
// }
