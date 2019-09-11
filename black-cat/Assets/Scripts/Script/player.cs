using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject again;
    public static player Ins;
    MapCon move;
    SpriteRenderer sprit;
  
    public Sprite Tiao_sp;
    public Sprite zhan_sp;
    public GameObject Map;
    [Header("人物起跳速度倍率")]
    public float JumpMapSpeed=1.6f;
    public float JumpMax = 1.2f;
    float CurrJumpTimer = 0;
    public bool isPlayerJumpState = false;
    AudioSource jump;
    AudioSource die;
    Rigidbody2D rig;
    //添加分数
    public float sort = 1;
    public GameObject s;
    GameManager GM;
    float li = 0;
    //float test = 1;

    float Mspeed;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        Ins = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        sprit = GetComponent<SpriteRenderer>();
        rig = GetComponent<Rigidbody2D>();
        GM = GameObject.Find("Manager").GetComponent<GameManager>();
        Mspeed = GM.MapSpeed;
        jump = gameObject.GetComponent<AudioSource>();
        die = GameObject.FindGameObjectWithTag("die").GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    //bool canJump = true;
    bool isJump = false;
    void Update()
    {
        s.GetComponent<Text>().text = sort.ToString("00");
        if (isPlayerJumpState)
        {
            GM.MapSpeed = Mspeed * JumpMapSpeed;
            sprit.sprite = Tiao_sp;

        }
            
        else
        {
            GM.MapSpeed = Mspeed;
        }
        if (Input.GetMouseButtonDown(0) && isPlayerJumpState == false)
        {
            isPlayerJumpState = true;
            CurrJumpTimer = JumpMax;
            rig.velocity = Vector2.up * 4;
            isJump = true;
            jump.Play();
        }
        if (Input.GetMouseButton(0) && isJump)
        {
            if (CurrJumpTimer > 0)
            {
                
                rig.velocity = Vector2.up * 4;
                CurrJumpTimer -= Time.deltaTime;

            }
            else
            {
                isJump = false;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            isJump = false;
        }

        

        //if (Input.GetMouseButtonDown(0))
        //{
        //    a = transform.position.y + 3;
        //}

        //if (Input.GetMouseButton(0))
        //{
        //    transform.Translate(Vector3.up * 16f * Time.deltaTime);
        //    //canJump = false;

        //}
    }  
    private void OnCollisionEnter2D(Collision2D other) {
        sprit.sprite = zhan_sp;
        li = 0;
        //GM.MapSpeed =Mspeed;
        isPlayerJumpState = false;
        sprit.sprite = zhan_sp;
        if (other.transform.tag=="Ground")
        {           
            Die();
        }
        if (other.transform.tag=="th")
        {
            iTween.MoveTo(Map, new Vector3(-110.7f, -12.0f, 0), 1.6f);
  
        }
        if (other.transform.tag == "tb")
        {
            isJump = true;
        }
        if (other.transform.tag == "diamond")
        {
            sort++;
        }
        




    }

    public void Die()
    {
        rig.AddForce(new Vector2(-400,400));
        again.SetActive(true);
        Time.timeScale = 0;
        die.Play();


    }


}

