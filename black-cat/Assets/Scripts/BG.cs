using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{

    private Game script;

    // Start is called before the first frame update
    void Start()
    {
        script = Camera.main.GetComponent<Game>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<= -18.12)
        {
            script.GetCanCreate = true;
            Destroy(gameObject);
        }
       
        
    }
}
