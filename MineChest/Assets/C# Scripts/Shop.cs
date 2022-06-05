using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    #region Singlton:Shop
    public static Shop Instance;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    #endregion

    //[SerializeField] GameObject ShopScrollView;
    [System.Serializable] public class ShopItem
    {
        public Sprite Image;
        public int Price;
        public bool IsPurchased = false;
    }
    [System.Serializable] public class ShopChest
    {
        public Sprite Image;
        public int Price;
        //public bool IsPurchased = false;
    }
    [System.Serializable]
    public class Collectable
    {
        public Sprite Image;
        public int Map;
        public int Possition;
        public bool Collected;
    }
    public List<ShopItem> shopItemsList;
    public List<ShopChest> shopChestsList;
    public List<Collectable> collectablesList;

    // Start is called before the first frame update
    void Start()
    {
        Shop.Instance.collectablesList[1].Collected = true;
        Shop.Instance.collectablesList[0].Collected = true;
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
