using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : MonoBehaviour
{
    public bool isPlayerNear = false;

    [SerializeField] int playerCurrency = 500;

    public List<Item> itemsForSale = new List<Item>();
    public GameObject shopMenuUI;

    InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        // Optional initialization
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            OpenMerchantDialogue();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            ShowHint("Press 'E' to interact with the Merchant.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            HideHint();
        }
    }

    void OpenMerchantDialogue()
    {
        // Open the dialogue UI here
        Debug.Log("Opening merchant dialogue...");
    }

    void ShowHint(string message)
    {
        // Display a hint to the player
        Debug.Log(message);
    }

    void HideHint()
    {
        // Hide the hint
        Debug.Log("Hint hidden");
    }

    public void PurchaseItem(Item item)
    {
        if (playerCurrency >= item.cost) // Assuming you have a currency tracking variable
        {
            playerCurrency -= item.cost; // Deduct the cost
            inventoryManager.AddItemToInventory(item); // Add the item to the playerÅfs inventory
            Debug.Log("Purchased: " + item.itemName);
        }
        else
        {
            Debug.Log("Not enough currency to purchase: " + item.itemName);
        }
    }    
}