using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private GameObject[] bgArray;
    private bool canCreate;
    //public Transform tra;

    public bool GetCanCreate
    {
        set { canCreate = value; }
        get { return canCreate; }
    }
    // Start is called before the first frame update
    void Start()
    {
       // tra = GameObject.Find("BG66 (1)").transform;
        canCreate = true;
        bgArray = Resources.LoadAll<GameObject>("BG"); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canCreate==true)
        {
          GameObject bg=Instantiate(bgArray[Random.Range(0,bgArray.Length)],new Vector3(17.5f, 1, 5),Quaternion.identity);
            if (bg.GetComponent<BG>()==null)
            {
                bg.AddComponent<BG>();
            }
            canCreate = false;
        }
        
    }
}
