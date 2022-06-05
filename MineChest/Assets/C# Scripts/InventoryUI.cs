using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    [Header("Layout Settings")]
    [SerializeField] float itemSpacing = .5f;
    float itemWidth = 235;

    [Header("UI elements")]
    [SerializeField] Transform InventoryMenu;
    [SerializeField] Transform InventoryToolsContainer;
    [SerializeField] GameObject toolPrefab;
    [Space(20)]
    [SerializeField] ItemShopDatabase toolDB;

    [Header("clothing UI elements")]
    [SerializeField] Transform InventoryClothingContainer;
    [SerializeField] GameObject clothingPrefab;
    [Space(20)]
    [SerializeField] ItemShopDatabase clothingDB;

    [Space(20)]
    [Header("Inventory Events")]
    [SerializeField] GameObject inventoryUI;
    [SerializeField] Animator EquipedAnim;
    [Space(20)]
    [SerializeField] Button InventoryButton;

    [SerializeField] GameObject player;
    void Start()
    {

        //Fill the Inventory's UI list with items
        RemoveInventoryItemsUI();
        GenerateInventoryItemsUI();
        InventoryButton.onClick.RemoveAllListeners();
        InventoryButton.onClick.AddListener(() => RemoveInventoryItemsUI());
        InventoryButton.onClick.AddListener(() => GenerateInventoryItemsUI());
        //Fill the Inventory's UI list with items

    }

    void RemoveInventoryItemsUI()
    {
        InventoryToolsContainer.DetachChildren();
        InventoryClothingContainer.DetachChildren();
    }
    void GenerateInventoryItemsUI()
    {
        //Loop throw save purchased items and make them as purchased in the Database array
        for (int i = 0; i < GameDataManager.GetAllPurchasedTools().Count; i++)
        {
            int purchasedToolIndex = GameDataManager.GetPurchasedTool(i);
            toolDB.PurchaseItem(purchasedToolIndex);
        }
        for (int i = 0; i < GameDataManager.GetAllPurchasedClothings().Count; i++)
        {
            int purchasedClothingIndex = GameDataManager.GetPurchasedClothing(i);
            clothingDB.PurchaseItem(purchasedClothingIndex);
        }
        int toolsCount = 0;
        int clothingCount = 0;
        
        //Generate Items
        for (int i = 0; i < toolDB.ItemsCount; i++)
        {
            //Create a Character and its corresponding UI element (uiItem)
            Item item = toolDB.GetItem(i);
            if(item.isPurchased != true)
            {
                continue;
            }
            ItemUI uiItem = Instantiate(toolPrefab, InventoryToolsContainer).GetComponent<ItemUI>();

            //Move item to its position
            uiItem.SetItemPosition(Vector2.right * toolsCount * (itemWidth + itemSpacing));
            toolsCount++;
            //Set Item name in Hierarchy (Not required)
            uiItem.gameObject.name = "Item" + i + "-" + item.name;

            //Add information to the UI (one item)
            uiItem.SetItemName(item.name);
            uiItem.SetItemImage(item.image);

            uiItem.OnItemEquip(i,OnToolEquip);

        }
        for (int i = 0; i < clothingDB.ItemsCount; i++)
        {
            //Create a Character and its corresponding UI element (uiItem)
            Item item = clothingDB.GetItem(i);
            if (item.isPurchased != true)
            {
                continue;
            }
            ItemUI uiItem = Instantiate(clothingPrefab, InventoryClothingContainer).GetComponent<ItemUI>();

            //Move item to its position
            uiItem.SetItemPosition(Vector2.right * clothingCount * (itemWidth + itemSpacing));
            clothingCount++;
            //Set Item name in Hierarchy (Not required)
            uiItem.gameObject.name = "Item" + i + "-" + item.name;

            //Add information to the UI (one item)
            uiItem.SetItemName(item.name);
            uiItem.SetItemImage(item.image);

            uiItem.OnItemEquip(i,OnClothingEquip);
        }
    }
    void OnToolEquip(int index)
    {
        //Equiped
        EquipedAnim.SetTrigger("Equipped");
        player.GetComponent<Clothes>().toolName = toolDB.GetItem(index).name;
    }
    void OnClothingEquip(int index)
    {
        //Equiped
        EquipedAnim.SetTrigger("Equipped");
        player.GetComponent<Clothes>().clothingName = clothingDB.GetItem(index).name;
    }






}

