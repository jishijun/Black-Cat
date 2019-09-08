using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCon : MonoBehaviour
{
      GameManager GM;
 
      public bool isMapRun = true;
     // Collider2D player;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("Manager").GetComponent<GameManager>();
        // Play = Player.GetComponent<Collider2D>();
       // player = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isMapRun)
        {
           gameObject.transform.Translate(Vector2.left*GM.MapSpeed*Time.deltaTime,Space.Self);
            
        }
        else
        {
            gameObject.transform.Translate(Vector2.right * GM.MapSpeed * Time.deltaTime, Space.Self);
        }
        //if (player.transform.tag == "fx")
        //    {
        //        Debug.Log("dfdfdf");
        //        transform.Translate(Vector2.right * GM.MapSpeed * Time.deltaTime, Space.Self);
        //    }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("dfdfdf");
            isMapRun = false;
           
        }
    }









}
