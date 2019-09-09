using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{

    GameObject player;

    public GameObject game;
    public GameObject tai;

    MapCon map;
    bool isPlayerTrack = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        map = GameObject.Find("Map").GetComponent<MapCon>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.parent.GetChild(0).GetChild(0).transform.position;

        if(isPlayerTrack)
        {
            map.isMapRun = false;
            player.transform.position = transform.GetChild(0).transform.position;

            if(Input.GetMouseButtonDown(0))
            {
                isPlayerTrack = false;
                map.isMapRun = true;
            }
        }
    }
    int a  = 1;
    private void OnCollisionEnter2D(Collision2D other) {

        if(other.gameObject.tag == "Player"&&a==1)
        {
            Debug.Log(1);
            a++;
            isPlayerTrack = true;
            transform.parent.GetComponent<Animator>().SetTrigger("isRot");

        }
    }

    private void OnCollisionStay2D(Collision2D other) {
       
    }
}
