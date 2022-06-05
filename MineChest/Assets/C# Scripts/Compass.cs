using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    private GameObject player;
    private GameObject chest;

    Vector3 position;
    Vector3 destination;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        chest = GameObject.Find("Chest");
    }

    // Update is called once per frame
    void Update()
    {
        position = player.transform.position;
        destination = chest.transform.position;
        float angle = Mathf.Atan2(destination.y-position.y,destination.x-position.x)*180 / Mathf.PI;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, angle-90), 1f);
    }
}
