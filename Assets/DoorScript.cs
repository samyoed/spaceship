using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public Animator anim;

    private void OnTriggerEnter(Collider other) // if player is within a certain distance of door 
    {
        if(other.gameObject.tag == "nobody")
        {
            anim.SetBool("character_nearby", true); // then open door
        }
        
            
    }
    private void OnTriggerExit(Collider other) // if player is beyond a certain distance of door
    {
        if (other.gameObject.tag == "nobody")
        {
            anim.SetBool("character_nearby", false); // then close door
        }
    }
}
