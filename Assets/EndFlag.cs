using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndFlag : MonoBehaviour {

    public Scene NextSceneName;

    void OnTriggerStay2D(Collider2D col)
    {
        SceneManager.LoadScene("game2");
    }
}
