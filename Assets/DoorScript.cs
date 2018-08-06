using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public Animator anim;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        


	}

    private void OnTriggerEnter(Collider other) // if player is within a certain distance of door then set character_nearby to true
    {
        if(other.gameObject.tag == "Player")
        {
            anim.SetBool("character_nearby", true);
        }
        
            
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("character_nearby", false);
        }
    }
}
