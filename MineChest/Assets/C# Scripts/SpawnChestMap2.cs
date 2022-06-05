using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChestMap2 : MonoBehaviour
{
    [SerializeField]
    private GameObject chest;
    [SerializeField]
    private SpriteRenderer renderer;

    public bool isOpened = false;

    // Start is called before the first frame update
    void Awake()
    {
        //Spawns randomly everytime game starts once       
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {

        if (isOpened) // if chest is digged, it trigers spawn
        {
            Spawn(); // reikia kad sukurtu nauja objekta
            isOpened = false;
        }

    }
    /*
    void Spawn() // blogos koordinates
    {
        Vector3 chestLoacation = new Vector3(Random.Range(-50f, 50f), Random.Range(-35f, 35f), 0f);
        chest.transform.position = chestLoacation;
        renderer.enabled = false;
        //Instantiate(chest, new Vector3(Random.Range(-50f, 50f), Random.Range(-35f,35f), 0f), Quaternion.identity);
    }
    */

    void Spawn()
    {
        int area = Random.Range(0, 10); // viso 10 skirtingu plotu, jei reikes plotu foto pavaizduotu zemelapy, imesiu
        if (area == 0) //1 t.t.
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-60f, -18.5f), Random.Range(33.6f, 44f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 1)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-38.4f, -31.5f), Random.Range(33.3f, 51.3f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 2)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-20f, -11f), Random.Range(41f, 53f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 3)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-55.5f, -50f), Random.Range(14f, 19.6f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 4)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-50f, -10f), Random.Range(-6.8f, 17.36f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 5)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-25.6f, -18.3f), Random.Range(-5f, 6f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 6)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-11f, -4f), Random.Range(26.7f, 31f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 7)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-2f, 0), Random.Range(31.7f, 43.3f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 8)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-33f, -26.6f), Random.Range(10f, 24.8f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 9)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-45.6f, -42f), Random.Range(-3.3f, 5f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
    }
}
