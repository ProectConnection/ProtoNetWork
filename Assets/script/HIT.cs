using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIT : MonoBehaviour {
    float kagocnt;
    // Use this for initialization
    void Start () {
        kagocnt = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        //Destroy(collision.gameObject);
        if (collision.transform.tag == "kago")
        {
            kagocnt++;
            Destroy(this.gameObject);
            Debug.Log(kagocnt);
        }
    }
}
