using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    public float speed = -15f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(transform.position.z <= -50)
        {
            transform.position = new Vector3(
                transform.position.x, transform.position.y, transform.position.z + 100);
        }
    }
}
