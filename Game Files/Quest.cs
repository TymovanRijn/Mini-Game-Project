public class Quest
{
    public bool Completed_Quest = false;
    public bool Active_Quest = false;
    public int Found_Item = 0;
    public int Total_Item;
    public string ItemName;
    public int Quest_ID;
    public string NPC_Name;
    public int Item_Reward_ID;
    public Quest(int quest_id, int total_item, string itemname, string npc_name, int item_reward_id)
    {
        this.Total_Item = total_item;
        this.ItemName = itemname;
        this.Quest_ID = quest_id;
        this.NPC_Name = npc_name;
        this.Item_Reward_ID;
    }

    public string Completed()//Gebruik bij de npc om te kijken of hij het kan inleveren
    {
        if (Found_Item >= Total_Item)
        {
            this.Completed_Quest = true;
            this.Active_Quest = false;
            return "You have completed the quest";
        }
        return $"You still need to find {Gathered}/{Total} items";

    }

    public string AddItem()//om item toe te voegen aan de benodigde items
    {
        Found_Item++;
        if (Found_Item >= Total_Item)
        {
            return $"You have completed the quest for {NPC.Name}";
        }
        else
        {
            return $"You have Found {Gathered}/{Total} items";
        }
    }

    public string Info()
    {
        if (this.Active_Quest is false)
        {
            return $"You have Found {Gathered}/{Total} items";
        }
    }

}