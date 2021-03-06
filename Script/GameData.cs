using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    public static GameData singleton;
    public Text scoreText = null;
    public int score = 0;

     void Awake()
    {
        GameObject[] gd = GameObject.FindGameObjectsWithTag("gamedata");
        if (gd.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        singleton = this; //

    }
   public void UpdateScore (int s)
    {
        score += s;
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }


}
