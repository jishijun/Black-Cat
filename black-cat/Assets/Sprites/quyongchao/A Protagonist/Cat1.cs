using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat1 : MonoBehaviour
{
    public float force = 20.0f;
    private Rigidbody2D rd;
    private PolygonCollider2D co;
    private BoxCollider2D box;
    public float JumpHeight = 1.0f;
    private float MaxJumpHeight = 3.0f;
    //public Vector3 dir;
    private bool isDead = false;
    private bool isJump = false;
    private bool ground;
    public bool canJump = false;
    private bool JetActive = false;

    // Start is called before the first frame update
    public int Count = 0;
    public AudioClip pick_gem;
    private Animator anim = null;

    private bool grounded = true;
    private Transform groundCheckPoint;
    private bool isgrounded = false;
    void Start()
    {
        box = this.GetComponentInChildren<BoxCollider2D>();
        rd = this.GetComponent<Rigidbody2D>();
        co = this.GetComponent<PolygonCollider2D>();
        anim = GetComponent<Animator>();
        groundCheckPoint = transform.Find("GroundCheckPoint");
        //di = GameObject.FindGameObjectsWithTag("Che");
        //dir = di.position.y - transform.position.x;
    }
    void Update()
    {
        JetActive = Input.GetButton("Fire1");
    }

    private void FixedUpdate()
    {
        if (transform.position.y >= MaxJumpHeight)
        {
            canJump = false;
            isJump = true;
        }
        if (JetActive && canJump)
        {
            rd.AddForce(new Vector2(0, force));
            isJump = true;
            anim.SetBool("jump", isJump);
        }
        if (isJump == true)
        {
            anim.SetBool("ground", isgrounded);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
            anim.SetBool("ground", isgrounded);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("diamond"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("diamond"))
        {
            AudioSource.PlayClipAtPoint(pick_gem, collision.transform.position);
            Destroy(collision.gameObject);
            Count++;
        }


        if (collision.gameObject.CompareTag("missile"))
        {
            Debug.Log("123");
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            //Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("bat"))
        {
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            //Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("frame"))
        {
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            canJump = false;
            Destroy(co);
            //Destroy(rd);
            force = 0.0f;
            //Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("ball"))
        {
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            //Time.timeScale = 0;
        }
        //if (collision.gameObject.CompareTag("Death level"))
        //{

        //}
        //if (collision.gameObject.CompareTag("ball"))
        //{

        //}


    }
}
