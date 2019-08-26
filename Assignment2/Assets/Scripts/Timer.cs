using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    private int saveTime = 0;

    void Start()
    {
        startTime = Time.time;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Car")
        {
            saveTime = 15;
            print("Ramp hit");
        }
    }

    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = ((t % 60)-saveTime).ToString("f2");
        //f2 betyder vi kun får 2 decimaler i float
        timerText.text = minutes + ":" + seconds;
    }

}
