using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnChest : MonoBehaviour
{
    [SerializeField]
    private GameObject chest;
    [SerializeField]
    private SpriteRenderer renderer;
    Scene currentScene;

    public bool isOpened = false;

    // Start is called before the first frame update
    void Awake()
    {
        //Gets what scene is playing
        currentScene = SceneManager.GetActiveScene();
        //Paziuri kuris zemelapis yra zaidziamas ir jame atspwanina chesta
        if (currentScene.name == "SampleScene")
        {
            SpawnMap1();
        }
        else if(currentScene.name == "Map2Scene")
        {
            SpawnMap2();
        }
        else if(currentScene.name == "Map3Scene")
        {
            SpawnMap3();
        }
        /*
        else
        {
            if (currentScene.name == "Map2Scene")
            {
                SpawnMap2();
            }
            else
            {
                if(currentScene.name == "Map3Scene")
                {
                    SpawnMap3();
                }
            }
        }
        */
    }

    // Update is called once per frame
    void Update()
    {

        if (isOpened) // if chest is digged, it trigers spawn
        {
            if (currentScene.name == "SampleScene")
            {
                SpawnMap1();
                isOpened = false;
            }
            else if(currentScene.name == "Map2Scene")
            {
                SpawnMap2();
                isOpened = false;
            }
            else if(currentScene.name == "Map3Scene")
            {
                SpawnMap3();
                isOpened = false;
            }
            /*
            else
            {
                if (currentScene.name == "Map2Scene")
                {
                    SpawnMap2();
                    isOpened = false;
                }
                else
                {
                    if(currentScene.name == "Map3Scene")
                    {
                        SpawnMap3();
                        isOpened = false;
                    }
                }
            }
            */

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

    //Pirmo zemelapio atsiradimo vietos
    void SpawnMap1()
    {
        int area = Random.Range(0, 12); // viso 12 skirtingu plotu, jei reikes plotu foto pavaizduotu zemelapy, imesiu
        if (area == 0)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-51, -32), Random.Range(45, 50), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 1)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-51, -43), Random.Range(7, 43), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 2)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-51, -50), Random.Range(0, 9), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 3)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-51, -60), Random.Range(11, 17), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 4)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-37, -2), Random.Range(-8, 17), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 5)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-2, 13), Random.Range(-4, 54), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 6)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-30, -1), Random.Range(16, 39), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 7)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-25, -1), Random.Range(35, 55), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 8)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(15, 32), Random.Range(-7, 2), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 9)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(32, 45), Random.Range(-11, -6), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 10)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(16, 36), Random.Range(45, 55), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 11)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(16, 32), Random.Range(36, 44), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
    }

    //Antro zemelapio atsiradimo vietos
    void SpawnMap2()
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



    //Trecio zemelapio atsiradimo vietos
    void SpawnMap3()
    {
        int area = Random.Range(0, 13); // viso 10 skirtingu plotu, jei reikes plotu foto pavaizduotu zemelapy, imesiu

        if (area == 0) //1 t.t.
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-20f, -14f), Random.Range(-3.7f, 14f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 1)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-17f, -10f), Random.Range(-11f, -4f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }

        else if (area == 2)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-10f, 10f), Random.Range(13f, 20f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 3)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(-10f, 11f), Random.Range(14.5f, 18.5f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 4)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(14f, 19f), Random.Range(6.4f, 15.7f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 5) // 6
        {
            Vector3 chestLoacation = new Vector3(Random.Range(22f, 28f), Random.Range(-7.5f, -2f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 6) // 7
        {
            Vector3 chestLoacation = new Vector3(Random.Range(31f, 66f), Random.Range(-12.5f, -7f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 12) // 6 antra dalis xd
        {
            Vector3 chestLoacation = new Vector3(Random.Range(22f, 27f), Random.Range(-16f, -11.6f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 7)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(62f, 72f), Random.Range(-15.5f, -9f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 8)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(19f, 25f), Random.Range(-37f, -23.5f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 9)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(26f, 32f), Random.Range(-48f, -40f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 10)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(43f, 57f), Random.Range(-56f, -48f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
        else if (area == 11)
        {
            Vector3 chestLoacation = new Vector3(Random.Range(73f, 80f), Random.Range(-37f, -23.2f), 0f);
            chest.transform.position = chestLoacation;
            renderer.enabled = false;
        }
    }
}
