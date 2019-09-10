using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    // Start is called before the first frame update
	public float speed = 1.0f;
	public Transform target;//目标位置
  public float distance;//两个物体的距离
  void Start () {
    Vector2 sudu = new Vector2(-speed,0);
    distance = Vector2.Distance (transform.position,target.position);
	
    }
       void Update () {
       transform.position = Vector2.MoveTowards (transform.position,target.position,(distance/100f)*Time.deltaTime);
  }


}
