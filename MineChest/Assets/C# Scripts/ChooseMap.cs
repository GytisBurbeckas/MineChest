using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMap : MonoBehaviour
{
    public void ChangeScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }   
}
