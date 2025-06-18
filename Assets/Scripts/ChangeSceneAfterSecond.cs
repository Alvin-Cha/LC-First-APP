using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneAfterSecond : MonoBehaviour
{
    public void ChangeAfterSecond(string scene_name){
        SceneManager.LoadScene(scene_name);
    }
}
