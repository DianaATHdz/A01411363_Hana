using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //Speed when moving
    public float speed = 2;
    //Direction of Movement
    Vector2 dir = Vector2.right;
    // Push force if we can kill it
    public float upForce = 800;
    public float damage = 500f;
    //	Public properties
    public int _damage = -1;            //	damage obtained 
    public LivesKeeper liveKeeper;        //	A link to the ScoreKeeper script
    private LevelManager levelManager;


    void Start()
    {
        liveKeeper = GameObject.FindObjectOfType<LivesKeeper>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }


    void FixedUpdate()
    {
        //Speed to move
        GetComponent<Rigidbody2D>().velocity = dir * speed;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        //If the object collides with our pivot, it changes direction
        transform.localScale = new Vector2(-1 * transform.localScale.x,
                                                transform.localScale.y);

        // And mirror it
        dir = new Vector2(-1 * dir.x, dir.y);

        if (coll.gameObject.tag == "Player")
        {
            liveKeeper.Lives(_damage);
        }
    }

    //	Getter for the damage property.
    public float getDamage()
    {
        return damage;
    }
}