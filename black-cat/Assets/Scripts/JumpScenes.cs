using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScenes : MonoBehaviour
{
    public GameObject again1;

    //public GameObject again2;
    //public GameObject again3;
    //public GameObject again4;
    //public GameObject again5;
    //public GameObject again6;
    //public GameObject again7;
    //public GameObject again8;
    //public GameObject again9;
    //public GameObject again10;
    // Start is called before the first frame update
    AudioSource Play;
   


    void Start()
    {
         Play = GameObject.Find("Playbutton").GetComponent<AudioSource>();
       // diamond = GameObject.FindGameObjectWithTag("diamond").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag=="Player")
        {
            //Debug.Log("121212121");
            Guanka();
        }
    }
    public  void   Guanka()
    {
       SceneManager.LoadScene("Guanka");
        Play.Play();


    }
    
    public void Home()
    {
        SceneManager.LoadScene("Home");
    }
    public void One()
    {
        SceneManager.LoadScene("One");
        again1.SetActive(false);
        Time.timeScale = 1;
    }
    public void Two()
    {
        SceneManager.LoadScene("Two");
        again1.SetActive(false);
        Time.timeScale = 1;
    }
    public void Three()
    {
        SceneManager.LoadScene("Three");
        again1.SetActive(false);
        Time.timeScale = 1;
    }
    public void Four()
    {
        SceneManager.LoadScene("Four");
        again1.SetActive(false);
        Time.timeScale = 1;
    }
    public void Five()
    {
        SceneManager.LoadScene("Five");
        again1.SetActive(false);
        Time.timeScale = 1;
    }
    public void Six()
    {
        SceneManager.LoadScene("Six");
        Time.timeScale = 1;
    }
    public void Seven()
    {
        SceneManager.LoadScene("Seven");
        Time.timeScale = 1;
    }
    public void Eight()
    {
        SceneManager.LoadScene("Eight");
    }
    public void Nine()
    {
        SceneManager.LoadScene("Nine");
    }
       public void Ten()
    {
        SceneManager.LoadScene("Ten");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }



}
