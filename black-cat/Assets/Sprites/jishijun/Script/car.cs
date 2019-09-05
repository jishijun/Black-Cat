using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public float Speed = 10.0f;
    public Rigidbody2D rig= null;
    public bool run = false;
    public float Force = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            run = true;
        }
    }
    public void FixedUpdate()
    {
        if(run==true)
        {
            rig.AddForce(new Vector2(Force, 0));
        }
    }
}
