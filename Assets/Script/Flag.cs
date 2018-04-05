using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour {
    //	Public properties
    public int scoreValue = 300;            //	Points obtained for collecting
    public ScoreKeeper scoreKeeper;        //	A link to the ScoreKeeper script
    private LevelManager levelManager;


    void Start()
    {
        scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            scoreKeeper.Score(scoreValue);
            Win();
        }
    }

    void Win()
    {
        LevelManager levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        levelManager.LoadNextLevel();
    }
}