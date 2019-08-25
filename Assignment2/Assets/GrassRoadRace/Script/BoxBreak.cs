using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxBreak : MonoBehaviour
{
    
    int pointCounter = 0;
    public AudioSource breakSource;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        breakSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollision(Collision col)
    {
        if(col.gameObject.tag == "Box")
        {
        breakSource.Play();
        Destroy(col.gameObject);
        pointCounter++;
        }
            t.text = "Score: " + pointCounter;
        
    }
}
