using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseSwitch : MonoBehaviour
{

    public Sprite lv;



    public delegate void shijian();

    public virtual void shi(){

    }
    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            this.GetComponent<SpriteRenderer>().sprite = lv;

            shi();
        }
    }
}
