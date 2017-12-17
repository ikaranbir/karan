using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextsceen : MonoBehaviour {


   public void Change(string Scenes)
    {
        SceneManager.LoadScene(Scenes);
    }
}