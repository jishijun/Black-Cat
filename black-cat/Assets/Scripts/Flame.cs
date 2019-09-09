using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : Basehit
{

    player player;
    BoxCollider2D Player_Coll;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("player").GetComponent<player>();
        Player_Coll = GameObject.Find("player").GetComponent<BoxCollider2D>();
    }



    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag =="Player")
        {
           // player.Die();
            Player_Coll.enabled = false;
        }
    }
}
