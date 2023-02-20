public class Quest
{
    public bool Completed_Quest = false; //true als de quest gedaan is.
    public bool Active_Quest = false;//true als de quest bezig is.
    public int Found_Item = 0;//totaal gevonden items.
    public int Total_Item;//totaal benodigde items.
    public string ItemName;//naam van de items.
    public int Quest_ID;//ID van de quest om makelijker te loopen indien nodig.
    public string NPC_Name;//NPC naam voor makelijker gespreken te maken.
    public int Item_Reward_ID;//Reward id zodat we de items in de inventory kunnen toevoegen.

    public int health = 100; //De health van de speler.
    public Quest(int quest_id, int total_item, string itemname, string npc_name, int item_reward_id)
    {
        this.Total_Item = total_item;
        this.ItemName = itemname;
        this.Quest_ID = quest_id;
        this.NPC_Name = npc_name;
        this.Item_Reward_ID = item_reward_id;
    }

    //reset de health bij een completed quest weer naar 100
    public void gain_health()
    {
        if (Completed_Quest = true)
        {
            health = 100;
        }
    }

    public string Completed()//Gebruik bij de npc om te kijken of hij het kan inleveren

    {
        if (Found_Item >= Total_Item)
        {
            this.Completed_Quest = true;
            this.Active_Quest = false;
        }
    }

    public string AddItem()//om item toe te voegen aan de benodigde items
    {
        Found_Item++;
        if (Found_Item >= Total_Item)
        {
            return ($"You have Found {Found_Item}/{this.Total_Item} items");
        }
        else
        {
            return $"You have Found {Found_Item}/{this.Total_Item} items";
        }
    }

    public string Info()//als we een manier maken zodat ze hun progressie kunnen zien.
    {
        if (this.Active_Quest is false)
        {
            return $"You have Found {Found_Item}/{this.Total_Item} items";
        }
        else
        {
            return $"You have Found {Found_Item}/{this.Total_Item} items";
        }
    }
}