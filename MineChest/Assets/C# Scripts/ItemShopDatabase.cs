using UnityEngine;

[CreateAssetMenu(fileName = "ItemShopDatabase", menuName = "Shopping/Items shop database")]
public class ItemShopDatabase : ScriptableObject
{
    public Item[] items;

    public int ItemsCount
    {
        get { return items.Length; }
    }

    public Item GetItem(int index)
    {
        return items[index];
    }

    public void PurchaseItem(int index)
    {
        items[index].isPurchased = true;
    }
}

