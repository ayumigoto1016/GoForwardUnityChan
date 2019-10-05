using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSound : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision){

		AudioSource SE = GetComponent<AudioSource> ();

		if (collision.gameObject.name == "ground" || collision.gameObject.name == "CubePrefab(Clone)" ) {

			SE.Play();

		} 
}
}
