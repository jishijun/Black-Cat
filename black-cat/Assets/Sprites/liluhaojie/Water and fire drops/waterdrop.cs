using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterdrop : MonoBehaviour
{
    public GameObject water;
	public float Timestart= 0;
	public float TimeInterval = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timestart += Time.deltaTime;
		if(Timestart>=TimeInterval){
			if(water){
			Vector2 newwater = new Vector2(transform.position.x-0.07f,transform.position.y-0.25f);
			Instantiate(water,newwater,Quaternion.identity);
			}
			Timestart = 0;
		}
    }
}
