using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public float speed = 700;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
            m_Rigidbody.AddForce(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey("a"))
            m_Rigidbody.AddForce(-speed * Time.deltaTime, 0, 0);
        if (Input.GetKey("w"))
            m_Rigidbody.AddForce(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("s"))
            m_Rigidbody.AddForce(0, 0, -speed * Time.deltaTime);


        // if (Input.GetKey("d"))
        // {
        //     Vector3 position = this.transform.position;
        //     position.x += this.speed;
        //     this.transform.position = position;
        // }
        // if (Input.GetKey("a"))
        // {
        //     Vector3 position = this.transform.position;
        //     position.x -= this.speed;
        //     this.transform.position = position;
        // }
        // if (Input.GetKey("w"))
        // {
        //     Vector3 position = this.transform.position;
        //     position.z += this.speed;
        //     this.transform.position = position;
        // }
        // if (Input.GetKey("s"))
        // {
        //     Vector3 position = this.transform.position;
        //     position.z -= this.speed;
        //     this.transform.position = position;
        // }
    }
}
