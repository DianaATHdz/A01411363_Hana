using UnityEngine;
using UnityEngine.SceneManagement;		// Requiered to switch scenes
using System.Collections;

//	This class will help us control how our game's scenes flow
public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)
    {
        //  Load the scene requested
        //  Debug.Log ("New Level load: " + name);
        //	Application.LoadLevel (name);    -- This method was deprecated a long time ago
        SceneManager.LoadScene(name);
    }

    public void EndGame()
    {
        //  Debug.Log ("Quit requested");
        Application.Quit();
    }

    //  We added these functions to our previous LevelManager script.
    public void LoadNextLevel()
    {
        //  Load the next scene in the build order
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

