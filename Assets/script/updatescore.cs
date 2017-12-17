using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class updatescore : MonoBehaviour {
    public Text ScoreText;

    static int score = 0;



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            score++;
            ScoreText.text = "Scores: " + score;


        }
    }
}
