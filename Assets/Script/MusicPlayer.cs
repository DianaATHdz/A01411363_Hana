using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    MusicPlayer instance = new MusicPlayer();

    // Use this for initialization
    void Start()
    {
        //If the instance is not null, then we destroy this gameObject s owe
        //do not have duplicates
        if (instance != null)
        {
            Destroy(gameObject);
        }
        //However, if the instance is indeed null, then we associate it to this
        //gameObjectn and we ask Unity not to destroy it on every load
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

}
