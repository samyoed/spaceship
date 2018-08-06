using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearbyScript : MonoBehaviour {

    public GameObject player;
   
	void Update () { // follows position of Player
        transform.position = player.GetComponent<Transform>().position;
	}
}
