﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jamminger : MonoBehaviour
{

    public Text ScoreText;
    static int Score =0;

    [SerializeField]
    GameObject mExplosionPrefab;

    void OnTriggerEnter2D(Collider2D col)
    {
        // TODO: Check if I am being hit by a bullet
        //       If that's the case, do the following:
        //          - Destroy the bullet
        //          - Destroy myself
        //          - Instantiate an explosion (use the prefab "mExplosionPrefab")

        if(col.gameObject.layer == LayerMask.NameToLayer("BusterBullet"))
        {
            Instantiate(mExplosionPrefab, transform.position,  Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject);
            Updatescore();
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        // TODO: Check if it's Mega Man (ignore everything else)
        //       If it is Mega Man, make him take some damage (e.g. 3 points)
        //       Use the TakeDamage() function from the MegaMan class!
        //       Check DeathZone.cs for an example of what to do !~
        if (col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            col.GetComponent<MegaMan>().TakeDamage(3);
        }
    }
    public void Updatescore()
    {
        Score = Score + 10;
        ScoreText.text = "Score =" + Score;
    }
}
