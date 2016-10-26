using UnityEngine;
using System.Collections;

public class WinTrigger : MonoBehaviour {

	// this class I modified from the leavetrigger script, this is attached to the last level piece in a level to call Winner() 

		void OnTriggerEnter (Collider other)
		{
			if (other.tag == "RollerBall") {
				Debug.Log ("FinishLine");
				//PlayerController.instance.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
				//PlayerController.instance.Winner ();
			}
		}
	}
