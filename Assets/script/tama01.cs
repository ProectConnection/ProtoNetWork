using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tama01 : MonoBehaviour {
    // Use this for initialization
    
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    void OnTriggerEnter(Collider collision)
    {
        //Destroy(collision.gameObject);
        if (collision.transform.tag == "Player" ) 
        {
            playermove.Ecnt++;
            Destroy(this.gameObject);
            
        }
    }
}
