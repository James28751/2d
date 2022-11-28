using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrow : MonoBehaviour
{
    public GameObject gamemaster;

    bool issa = false;
    // Start is called before the first frame update
    void Start()
    {
        gamemaster = GameObject.Find("GameObject");
        Destroy(gameObject,3);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y< -6.5f && issa==false )
        {
            gamemaster.GetComponent<gamemaster>().iss();
            issa = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
