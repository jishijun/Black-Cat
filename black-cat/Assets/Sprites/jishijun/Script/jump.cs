using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Animation anim;
    private Rigidbody2D rig;
    private float Force;
    public bool isground;
    public float MaxHeight;
    private bool canJump;
    private bool isJump;
    private bool rd = false;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Force = 50.0f;
        anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        rd = Input.GetButton("Fire1");
    }
    private void FixedUpdate()
    {
        if(transform.position.y>=MaxHeight)
        {
            canJump = true;
            isJump = false;
        }
        if(rig && canJump)
        {
            rig.AddForce(new Vector2(0, Force));
            isJump = true;
            //anim.SetBool("jump", isJump);
        }
        //if(isJump==true)
        //{
        //    anim.SetBool("ground", isground);
        //}
    }
}
