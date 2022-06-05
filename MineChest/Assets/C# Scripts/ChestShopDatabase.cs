using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChestShopDatabase", menuName = "Shopping/Chests shop database")]
public class ChestShopDatabase : ScriptableObject
{
    public Chest[] chests;

    public int ChestsCount
    {
        get { return chests.Length; }
    }

    public Chest GetChest(int index)
    {
        return chests[index];
    }

    //public void PurchaseItem(int index)
    //{
    //    chests[index].isPurchased = true;
    //}
}