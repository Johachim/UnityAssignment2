using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bullet;
    public float speed = 100f;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject inBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody inBulletRigid = inBullet.GetComponent<Rigidbody>();
            inBulletRigid.AddForce(Vector3.forward * speed);
        }
    }
}
