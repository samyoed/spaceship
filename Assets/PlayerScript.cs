using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public int jumpSpeed = 10;
    public int walkSpeed = 5;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    //private float pitch = 0.0f;

    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //pitch -= speedV * Input.GetAxis("Mouse Y");

        yaw += speedH * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);



        // player movement
        //Vector3 playerMovement = new Vector3(Input.GetAxis("Horizontal") * walkSpeed, 0, 0);
        //GetComponent<Rigidbody>().velocity = playerMovement;

        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpSpeed, 0));
        }

        if (Input.GetButton("Vertical"))
        {
            GetComponent<Rigidbody>().velocity = transform.forward * Input.GetAxis("Vertical") * walkSpeed;
        }

    }
}
