using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    Rigidbody myRB;
    // Start is called before the first frame
    void Start()
    {
        {
            myRB = GetComponent<Rigidbody>();
        }
    }



    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
            
            myRB.AddForce(transform.forward);

            transform.position += transform.forward * Time.deltaTime;


        if (Input.GetKey(KeyCode.S))

            myRB.AddExplosionForce(10, transform.position + Vector3.down, 5);

            transform.position -= transform.forward * Time.deltaTime;
            



        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.up,-90 * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.down,-180 * Time.deltaTime);
}
}