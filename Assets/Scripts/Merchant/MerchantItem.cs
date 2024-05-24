using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;
    public int cost;
    public Sprite icon; // For UI display purposes

    public Item(string name, int itemCost, Sprite itemIcon)
    {
        itemName = name;
        cost = itemCost;
        icon = itemIcon;
    }
}