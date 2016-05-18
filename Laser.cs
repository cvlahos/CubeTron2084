using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour 
{
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D(Collider2D laserHit)

	{
		

		if (laserHit.gameObject.tag == "Playfield" || laserHit.gameObject.tag == "BadBot")
		{
			Destroy (gameObject);
		}
			
	
	}


}
