using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond : MonoBehaviour
{
    public GameObject diamond1;
    public GameObject Par;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        diamond1.SetActive(false);
        Vector2 Parti = new Vector2(transform.position.x, transform.position.y);
        Instantiate(Par, Parti, Quaternion.identity);
        Par.SetActive(true);

    }
}
