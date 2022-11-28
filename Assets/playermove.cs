using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public GameObject gamemaster;
    public AudioClip walk;
    public AudioClip hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
         
            this.GetComponent<AudioSource>().clip = walk;
            transform.Translate(-3, 0, 0);
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.GetComponent<AudioSource>().clip = walk;
            transform.Translate(3, 0, 0);
            GetComponent<AudioSource>().Play();
        }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        this.GetComponent<AudioSource>().clip = hit;
        GetComponent<AudioSource>().Play();
        gamemaster.GetComponent<gamemaster>().HPhit();
    }
    public void LButton()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButton()
    {
        transform.Translate(3, 0, 0);
    }
}
