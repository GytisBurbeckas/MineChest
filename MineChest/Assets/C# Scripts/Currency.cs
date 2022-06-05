using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Currency : MonoBehaviour
{

    public int lootfromChest;
    public int minCurrencyGained;
    public int maxCurrencyGained;

    private GameObject chest;
    private float chestX;
    private float chestY;
    private Animator chestAnimator;

    private GameObject loot;
    private SpriteRenderer lootRenderer;
    private Animator lootAnimator;

    private GameObject lootPopup;
    private TextMeshPro lootPopupTextMesh;

    private bool addCoins = false;
    // Start is called before the first frame update
    void Start()
    {
        chest = GameObject.Find("Chest");
        chestAnimator = chest.GetComponent<Animator>();
        chestX = chest.transform.position.x;
        chestY = chest.transform.position.y;


        lootRenderer = GetComponent<SpriteRenderer>();
        lootAnimator = GetComponent<Animator>();
        loot = GameObject.Find("Loot");

        lootPopup = GameObject.Find("LootPopup");
        lootPopupTextMesh = lootPopup.GetComponent<TextMeshPro>();

        lootfromChest = LootFromChest(minCurrencyGained, maxCurrencyGained);
        lootRenderer.enabled = false;
        lootPopupTextMesh.text = "";
        lootPopup.transform.position = new Vector3(chest.transform.position.x-0.2f, chest.transform.position.y + 1.5f, chest.transform.position.z);
        loot.transform.position = new Vector3(chest.transform.position.x-0.1f, chest.transform.position.y + 2, chest.transform.position.z);
        lootAnimator.SetBool("IsShowing", false);
    }

    // Update is called once per frame
    void Update()
    {
        //Cheks if the chest changed position
        if (chestX != chest.transform.position.x && chestY != chest.transform.position.y)
        {
            //Genarate loot for chest and save it's position
            lootfromChest = LootFromChest(minCurrencyGained, maxCurrencyGained);
            chestX = chest.transform.position.x;
            chestY = chest.transform.position.y;

            lootRenderer.enabled = false;
            loot.transform.position = new Vector3(chest.transform.position.x-0.1f, chest.transform.position.y + 2, chest.transform.position.z);
            lootPopupTextMesh.text = "";
            lootPopup.transform.position = new Vector3(chest.transform.position.x-0.2f, chest.transform.position.y + 1.5f, chest.transform.position.z);
            lootAnimator.SetBool("IsShowing", false);
        }

        if (chestAnimator.GetCurrentAnimatorStateInfo(0).IsTag("1"))
        {
            lootRenderer.enabled = true;
            lootPopupTextMesh.text = lootfromChest.ToString();
            lootAnimator.SetBool("IsShowing", true);
            addCoins = true;
        }

        if (addCoins && !chestAnimator.GetCurrentAnimatorStateInfo(0).IsTag("1"))
        {
            GameDataManager.AddCoins(lootfromChest);
            addCoins = false;
        }
    }

    public int LootFromChest(int min,int max)
    {
        return Random.Range(min, max);
    }
}
