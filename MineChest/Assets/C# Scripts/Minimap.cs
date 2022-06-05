using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    private Camera minimap;
    private Animator chestAnimator;
    // Start is called before the first frame update
    void Start()
    {
        chestAnimator = GameObject.Find("Chest").GetComponent<Animator>();
        minimap = GetComponent<Camera>();
        minimap.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("m"))
        {
            minimap.enabled = true;
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
        }
        else
        {
            minimap.enabled = false;
            if (chestAnimator.GetCurrentAnimatorStateInfo(0).IsTag("1"))
            {
                GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
            }
            else
            {
                GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = true;
            }
        }

    }
}
