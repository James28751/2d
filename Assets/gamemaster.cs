using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemaster : MonoBehaviour
{
    public GameObject arrow;
    float time = 1.0f;
    float delta = 0;
    public GameObject HP;
    int a;
    GameObject gg;


    // Start is called before the first frame update
    void Start()
    {
        gg = GameObject.Find("g");
        gg.GetComponent<Text>().text = $"分數:{a}";
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
    public void HPhit()
    {
        HP.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void iss()
        {
        a += 100;
        gg.GetComponent<Text>().text = $"分數:{a}";
    }
}
