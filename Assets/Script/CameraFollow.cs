using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        //Modificamos la posición de la camara a nuestra nueva altura
        Camera.main.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, Camera.main.transform.position.z);
    }
}
