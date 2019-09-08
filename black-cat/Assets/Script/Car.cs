using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    GameManager GM;

    public bool isRun = false;
    public int fx=0;
    float speed ;


    // Start is called before the first frame update
    void Start()
    {
        GM=GameObject.Find("Manager").GetComponent<GameManager>();
        speed = GM.MapSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(isRun&&fx==0)
        {
            transform.Translate(Vector2.right * speed*Time.deltaTime , Space.Self);
        }
        if (isRun==false&&fx==1)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime, Space.Self);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag =="Player")
        {
            isRun = true;
    

           // speed = GM.MapSpeed;
        }
        if (other.gameObject.tag=="fx")
        {
            isRun = false;
            fx = 1;
        }
    }
}
