using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    float blastspeed;
  
    // Start is called before the first frame update
    void Start()
    {
        blastspeed = speed * 2.0f;
        Vector2 sudu = new Vector2(speed, 0);
        GetComponent<Rigidbody2D>().velocity = sudu;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
