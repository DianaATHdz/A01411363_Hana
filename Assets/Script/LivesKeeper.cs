using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				//	We need this in order to handle the Text object

public class LivesKeeper : MonoBehaviour {

    public int lives = 5;            //	Player's lives
    public Text liveText;			//	So we can modify the live's Text

	// Use this for initialization
	void Start () {
		//	We dynamicaly point to the Text object in our UI.
		liveText = GetComponent<Text> ();
		//Reset ();
		liveText.text = lives.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
        liveText.text = lives.ToString();
    }

    public void Lives(int points)
    {
        lives += points;
        Update();
    }

    public void Reset() {
        lives = 5;
		// scoreText.text = score.ToString ();
	}

}
