using UnityEngine;
using System.Collections;

public class PlayerControlScript : MonoBehaviour {
	public float jumpForce = 10;
	public bool isInAir = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!isInAir && Input.GetKeyDown(KeyCode.A)){
			isInAir = true;
			transform.rigidbody.AddForce(new Vector3(0,jumpForce,0));
		}

	}
	void OnCollisionEnter(Collision collision){
		Debug.Log ("Hit something!");
		isInAir = false;

	}
}

