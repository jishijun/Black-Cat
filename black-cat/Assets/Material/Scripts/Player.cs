using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public int hight;
   public int upspeed;
    Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
             
    }

    // Update is called once per frame
    void Update()
    {
        //按下空格键可以使方块跳跃
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics2D.Raycast(transform.position, Vector2.down, hight, LayerMask.GetMask("ground")))
            {
                player.AddForce(Vector3.up * upspeed, ForceMode2D.Impulse);    //给它一个向上的力
            }
            if (Physics2D.Raycast(transform.position, Vector2.down, hight, LayerMask.GetMask("ceiling")))
            {
                player.AddForce(Vector3.up * upspeed, ForceMode2D.Impulse);    //给它一个向上的力
            }
        }


    }
}
