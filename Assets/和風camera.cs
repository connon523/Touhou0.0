using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 和風camera : MonoBehaviour
{
    private float mSpeed = 6.0F;
    void Start()
    {

    }


    void Update()
    {
        
        transform.Translate(Vector3.right * Time.deltaTime * mSpeed);
       
        if (transform.position.x >= 19.9F)
        {
           
            transform.position = new Vector3(0F, transform.position.y, transform.position.z);
        }
    }
}
