using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<Item> playerInventory = new List<Item>();

    // Singleton pattern for easy access
    public static InventoryManager Instance;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddItemToInventory(Item item)
    {
        playerInventory.Add(item);
        Debug.Log(item.itemName + " has been added to your inventory.");
        // Optionally update the inventory UI here
    }
}