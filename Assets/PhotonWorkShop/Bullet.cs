using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		PhotonView myView = gameObject.GetComponent<PhotonView> ();
		if (other.gameObject.tag == "Player") {
			if (myView.isMine) {
				PhotonNetwork.Destroy (gameObject);
			}
		}
	}
		

}
