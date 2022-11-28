using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemaster : MonoBehaviour
{
    public GameObject arrow;
    float time = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > time)
        {
            delta = 0;
            int a = Random.Range(-9, 9);
            Instantiate(arrow, new Vector3(a, 5, 0), Quaternion.identity);
        }
    }
}
