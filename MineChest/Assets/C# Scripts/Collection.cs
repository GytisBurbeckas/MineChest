using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection : MonoBehaviour
{
    [Header("Layout Settings")]
    [SerializeField] float itemSpacing = .5f;
    float itemWidth = 235;

    
    [Space(20)]
    [SerializeField] CollectablesDatabase collectablesDB;
    [SerializeField] Transform CollectionMenu;
    [Header("Map1 elements")]
    [SerializeField] Transform Map1Container;
    [SerializeField] GameObject coin1Prefab;
    

    [Header("Map2 elements")]
    [SerializeField] Transform Map2Container;
    [SerializeField] GameObject coin2Prefab;

    [Header("Map3 elements")]
    [SerializeField] Transform Map3Container;
    [SerializeField] GameObject coin3Prefab;

    [Space(20)]
    [SerializeField] Button CollectionButton;
    void Start()
    {

        //Fill the Collection's UI list with items
        RemoveCollectionItemsUI();
        GenerateCollectionItemsUI();
        CollectionButton.onClick.RemoveAllListeners();
        CollectionButton.onClick.AddListener(() => RemoveCollectionItemsUI());
        CollectionButton.onClick.AddListener(() => GenerateCollectionItemsUI());

    }

    void RemoveCollectionItemsUI()
    {
        Map1Container.DetachChildren();
        Map2Container.DetachChildren();
        Map3Container.DetachChildren();
    }
    void GenerateCollectionItemsUI()
    {
        //Loop throw save collected collectables and make them as purchased in the Database array
        for (int i = 0; i < GameDataManager.GetAllCollectedCollectables().Count; i++)
        {
            int collectedCollectableIndex = GameDataManager.GetCollectedCollectable(i);
            collectablesDB.CollectCollectable(collectedCollectableIndex);
        }
        int map1Count = 0;
        int map2Count = 0;
        int map3Count = 0;

        //Generate Items
        for (int i = 0; i < collectablesDB.CollectablesCount; i++)
        {
            //Create a Character and its corresponding UI element (uiItem)
            Collectable collectable = collectablesDB.GetCollectables(i);
            if(collectable.isCollected == false)
            {
                continue;
            }
            if (collectable.id <= 3)
            {
                ItemUI uiItem = Instantiate(coin1Prefab, Map1Container).GetComponent<ItemUI>();
                //Move item to its position
                uiItem.SetItemPosition(Vector2.right * map1Count * (itemWidth + itemSpacing));
                map1Count++;
                
                uiItem.SetItemImage(collectable.image);
                continue;
            }
            if (collectable.id <= 6)
            {
                ItemUI uiItem = Instantiate(coin2Prefab, Map2Container).GetComponent<ItemUI>();
                //Move item to its position
                uiItem.SetItemPosition(Vector2.right * map2Count * (itemWidth + itemSpacing));
                map2Count++;

                uiItem.SetItemImage(collectable.image);
                continue;
            }
            if (collectable.id <= 9)
            {
                ItemUI uiItem = Instantiate(coin3Prefab, Map3Container).GetComponent<ItemUI>();
                //Move item to its position
                uiItem.SetItemPosition(Vector2.right * map3Count * (itemWidth + itemSpacing));
                map3Count++;

                uiItem.SetItemImage(collectable.image);
                continue;
            }
            
           
            

        }
    }
    //[SerializeField] GameObject Map1Coin1UITemplate;
    //[SerializeField] GameObject Map1Coin2UITemplate;
    //[SerializeField] GameObject Map1Coin3UITemplate;
    //[SerializeField] GameObject Map2Coin1UITemplate;
    //[SerializeField] GameObject Map2Coin2UITemplate;
    //[SerializeField] GameObject Map2Coin3UITemplate;
    //[SerializeField] GameObject Map3Coin1UITemplate;
    //[SerializeField] GameObject Map3Coin2UITemplate;
    //[SerializeField] GameObject Map3Coin3UITemplate;

    //void GetAvailableCollectables()
    //{
    //    if (Shop.Instance == null)
    //        return;
    //    //Map2Coin3UITemplate.SetActive(true);
    //    for (int i = 0; i < Shop.Instance.collectablesList.Count; i++)
    //    {
    //        if (Shop.Instance.collectablesList[i].Collected == false)
    //            continue;
    //        int map = Shop.Instance.collectablesList[i].Map;
    //        int coin = Shop.Instance.collectablesList[i].Possition;
    //        if (map == 1)
    //        {
    //            if (coin == 1)
    //                Map1Coin1UITemplate.SetActive(true);
    //            if (coin == 2)
    //                Map1Coin2UITemplate.SetActive(true);
    //            if (coin == 3)
    //                Map1Coin3UITemplate.SetActive(true);
    //        }
    //        if (map == 2)
    //        {
    //            if (coin == 1)
    //                Map2Coin1UITemplate.SetActive(true);
    //            if (coin == 2)
    //                Map2Coin2UITemplate.SetActive(true);
    //            if (coin == 3)
    //                Map2Coin3UITemplate.SetActive(true);
    //        }
    //        if (map == 3)
    //        {
    //            if (coin == 1)
    //                Map3Coin1UITemplate.SetActive(true);
    //            if (coin == 2)
    //                Map3Coin2UITemplate.SetActive(true);
    //            if (coin == 3)
    //                Map3Coin3UITemplate.SetActive(true);
    //        }
    //    }
    //}
}
