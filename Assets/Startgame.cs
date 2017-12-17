using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour {

    public void Change(string SceneName)
    {

        SceneManager.LoadScene(SceneName);
    }
}