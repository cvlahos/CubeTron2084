using UnityEngine;
using System.Collections;

public class GetComponent : MonoBehaviour 
{
	//
	public GameObject laserPrefab;
	public float laserSpeed;

	Transform playerTR;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{


	}

	void FireLaserExample()
	{
		GameObject upRTLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;

		upRTLaser.GetComponent<Transform>().Rotate(0,0,-45); //takes over the transform of the laser's prefab and rotates the laser -45 degrees
		
		upRTLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(laserSpeed, laserSpeed); //takes over the laser's rigidbody and forces the laser in specified direction
	}


	void FindGameObjectAndGetComponent()
	{
	
		playerTR = GameObject.Find ("Player").GetComponent<Transform> (); // looks for the player in the level and then gets control of the player's transform and assigns to playerTR


	}

}
