using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject EnemyPrefab;
	public float chancePerFrame = 0.1f;
	public int minimumFrameDelay = 0;
	public float upDownChance = 0.2f; //Chance of spawning up vs spawning down.
	public float heightOffset = 2;
	private float _frameDelay = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (_frameDelay-- < 0) {
			if (Random.Range (0.0f, 1.0f) < chancePerFrame) {
				_frameDelay = minimumFrameDelay;
				Vector3 pos = transform.position;
				if(Random.Range(0.0f,1.0f) < upDownChance){
					pos.y += heightOffset;
				}
				Instantiate(EnemyPrefab,pos,EnemyPrefab.transform.rotation);
			}
		}
	}
}
