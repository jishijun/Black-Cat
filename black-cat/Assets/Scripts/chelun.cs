using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chelun : MonoBehaviour
{


    public bool isDong = false;

    // Update is called once per frame
    void Update()
    {
        isDong = transform.parent.GetComponent<Car>().isRun;
        if(isDong)
            transform.Rotate(Vector3.back,200*Time.deltaTime);
    }
}
