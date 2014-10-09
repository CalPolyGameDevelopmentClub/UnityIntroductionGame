using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(-speed,0,0));
		if(transform.position.x < -20){
			Destroy(gameObject);
		}
	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Player") {
			Destroy(collision.gameObject);		
		}
	}
}
