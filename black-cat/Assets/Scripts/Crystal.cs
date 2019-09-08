using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Crystal : MonoBehaviour
{
    AudioSource diamond;
   
    

    void Start()
    {
        diamond = GameObject.FindGameObjectWithTag("diamond").GetComponent<AudioSource>();
        // Play = Player.GetComponent<Collider2D>();
       
    }
   

    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag=="Player")
        {
            diamond.Play();
            Destroy(gameObject);
           
        }
       
    }
   



}
