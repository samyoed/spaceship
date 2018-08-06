using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{

    private ParticleSystem ps;
    private int color = 0;

    // Use this for initialization
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update() //if right mouse button is pressed, change color of particle system
    {
        var main = ps.main;
        if (Input.GetButtonDown("Fire2"))
        {
            color = color + 1;
            if (color > 2)
            {
                color = 0;
            }
        }
        switch (color) // on every right mouse click, color will switch between blue, purple, and green
        {
            case 0:
                main.startColor = new Color(0, 100, 255);
                break;

            case 1:
                main.startColor = new Color(255, 0, 100);
                break;

            case 2:
                main.startColor = new Color(100, 255, 0);
                break;

        }
    }

    //    private void OnTriggerStay(Collider other) // if player is within a certain distance of door then set character_nearby to true
    //    {
    //        if (other.gameObject.tag == "nobody" && Input.GetButtonDown("Fire1"))
    //        {
    //            Debug.Log("itwerkss");



    //    }
}
