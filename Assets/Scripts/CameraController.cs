using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject actor;
	public float moveSpeed = 0;
	private Vector3 actorPos;  

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () {

		actorPos = new Vector3 (actor.transform.position.x, actor.transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, actorPos, moveSpeed * Time.deltaTime);

	}
}
