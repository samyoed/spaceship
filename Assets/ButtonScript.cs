using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public Animator anim;
    private bool isPressingFire;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            isPressingFire = true;
        }
        else if(Input.GetButtonUp("Fire1"))
        {
            isPressingFire = false;
        }


	}
    private void OnTriggerStay(Collider other) // if player is within a certain distance of button and is pressing left mouse button
    {
        if (other.gameObject.tag == "nobody" && isPressingFire )
        {
            Debug.Log("itwerks");
            anim.SetBool("character_nearby", true); // then open door
        }


    }
    private void OnTriggerExit(Collider other) // if player is beyonda certain distance of button
    {
        if (other.gameObject.tag == "nobody")
        {
            anim.SetBool("character_nearby", false); // then close door
        }
    }
}
