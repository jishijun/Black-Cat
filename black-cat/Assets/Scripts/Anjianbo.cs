using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anjianbo : MonoBehaviour
{
    public Vector3 screenPosition;
    public Vector3 mousePositionOnScreen;
    public Vector3 mousePositionInWorld;
    public GameObject Soldier;
   // Animation ani;
    // Start is called before the first frame update
    void Start()
    {
       // ani = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        mousePositionOnScreen = Input.mousePosition; mousePositionOnScreen.z = screenPosition.z;
        mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePositionOnScreen);
        if (Input.GetMouseButtonDown(0))
        {
          GameObject ll=  Instantiate(Soldier, mousePositionInWorld, Quaternion.identity);
            Destroy(ll.gameObject, 0.3f);
        }
    }
    public void TakePhotos()
    {
        ScreenCapture.CaptureScreenshot(Application.streamingAssetsPath + "/ScreenShot.png", 0);
    }
}
