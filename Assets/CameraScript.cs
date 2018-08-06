using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject player;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public int walkSpeed = 5;
    public float camOffset = 20;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 playerPos = player.GetComponent<Transform>().position;



        transform.position = new Vector3 (playerPos.x, playerPos.y + camOffset, playerPos.z);


        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        //if (Input.GetButton("Vertical"))
        //{
            //GetComponent<Rigidbody>().velocity = transform.forward * Input.GetAxis("Vertical") * walkSpeed;
        //}
    }
}
