public class Quest
{
    public int Gathered = 0;
    public int Total;
    public string ItemName;
    public int Quest_ID;
    public Quest(int quest_id, int total, string itemname)
    {
        this.Total = total;
        this.ItemName = itemname;
        this.Quest_ID = quest_id;
    }

    public string Completed()
    {
        if (Gathered >= Found)
        {
            return "You have completed the quest";
        }
        return $"you still need to find {Gathered}/{Total} items";

    }

    public int Found()
    {
        Gathered++;
    }

    
}