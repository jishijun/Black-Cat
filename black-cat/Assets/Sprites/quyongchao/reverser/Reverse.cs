using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverse : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("car"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }

}
