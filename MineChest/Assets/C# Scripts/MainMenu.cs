using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //#region Singlton:MainMenu
    //public static MainMenu Instance;
    //void Awake()
    //{
    //    if (Instance == null)
    //    {
    //        Instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //        Destroy(gameObject);
    //}
    //#endregion

    //[System.Serializable] // collectable coins
    //public class Collectable
    //{
    //    public Sprite Image;
    //    public int Map;
    //    public int Possition;
    //    public bool Collected;
    //}
    //public List<Collectable> collectablesList;


    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
