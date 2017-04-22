using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

	public Rigidbody rigidbody;

	// Use this for initialization
	public float tumble;

	void Start ()
	{
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
