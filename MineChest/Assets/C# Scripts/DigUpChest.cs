using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//[System.Serializable]
public class DigUpChest : MonoBehaviour
{
    private SpriteRenderer chestRenderer;
    private BoxCollider2D chestColider;
    public BoxCollider2D chestTriger;
    private BoxCollider2D playerColider;
    private Animator playerAnimator;
    private GameObject player;
    private Animator chestAnimator;
    private bool moveChest = false;

    private void Start()
    {
        player = GameObject.Find("Player");
        playerAnimator = player.GetComponent<Animator>();
        playerColider = player.GetComponent<BoxCollider2D>();

        chestRenderer = GameObject.Find("Chest").GetComponent<SpriteRenderer>();
        chestColider = GameObject.Find("Chest").GetComponent<BoxCollider2D>();
        chestAnimator = GameObject.Find("Chest").GetComponent<Animator>();
        chestColider.enabled = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        DigChest();
        
        if (Input.GetKey("g") && chestRenderer.enabled && playerColider.bounds.Intersects(chestTriger.bounds)) // to open chest, possible only if player intersects chest bounds, press g and chest is digged
        {
            chestAnimator.SetBool("IsOpen", true);
        }


        if (chestAnimator.GetCurrentAnimatorStateInfo(0).IsTag("1") && chestAnimator.GetBool("IsOpen"))
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            chestAnimator.SetBool("IsOpen", false);
            moveChest = true;
        }

        if (chestAnimator.GetCurrentAnimatorStateInfo(0).IsTag("2") && moveChest)
        {
            player.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("Chest").GetComponent<SpawnChest>().isOpened = true;
            chestColider.enabled = false;
            moveChest = false;
        }
    }

    void DigChest()
    {
        if (Input.GetKey("f"))
        {
            playerAnimator.SetBool("dig", true);
            if (playerColider.bounds.Intersects(chestTriger.bounds))
            {
                chestRenderer.enabled = true;
                chestColider.enabled = true;
            }
            //if (AudioScript.isPlaying)
            //{
                AudioScript.PlaySound("audioGarsas");
              //  AudioScript.setBoolFalse();
            //}
        }
        else
        {
            playerAnimator.SetBool("dig", false);
            //AudioScript.setBoolTrue();
        }
    }

}
