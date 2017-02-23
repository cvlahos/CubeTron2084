using UnityEngine;
using System.Collections;

public class AutoFire : MonoBehaviour 
{

	public float laserSpeed;

	public GameObject laserPrefab;
	public MusicManager musicManager;

	float timer; // here is the variable for time
	public float shotDelay; // the higher the number the longer the delay
	
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// here is where we create a clock counting higher from 0 
		timer = timer + Time.deltaTime; // think of time.deltaTime as real world seconds

		FireLaser ();
	}
	
	

	
	//Instead of having 8 different prefabs for each laser direction there is a more efficient way to instantiate as a game object where we can get control of components
	
	
	void FireLaser()
	{
		//laser up
		if (Input.GetKey(KeyCode.Keypad8) && timer >= shotDelay) 
		{
			timer = 0f; // reseting the timer to 0 will make this if statement false so the player can't fire
			musicManager.PlayLaserSound();
			GameObject upLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			upLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, laserSpeed);
			
		}
		//laser up,right
		if (Input.GetKey(KeyCode.Keypad9) && timer >= shotDelay)
		{
			timer = 0f; // reseting the timer to 0 will make this if statement false so the player can't fire
			musicManager.PlayLaserSound();
			GameObject upRTLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			upRTLaser.GetComponent<Transform>().Rotate(0,0,-45); //rotated the laser -45 degrees
			upRTLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(laserSpeed, laserSpeed); //gave the laser speed to match it's new rotation
			
		}
		
		//laser right
		if (Input.GetKey(KeyCode.Keypad6) && timer >= shotDelay) 
		{
			timer = 0f; // reseting the timer to 0 will make this if statement false so the player can't fire
			musicManager.PlayLaserSound();
			GameObject RTLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			RTLaser.GetComponent<Transform>().Rotate(0,0,-90);
			RTLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(laserSpeed, 0);
			
			
		}
		//laser down,right
		if (Input.GetKey(KeyCode.Keypad3) && timer >= shotDelay)
		{
			timer = 0f; // reseting the timer to 0 will make this if statement false so the player can't fire
			musicManager.PlayLaserSound();
			GameObject rtDownLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			rtDownLaser.GetComponent<Transform>().Rotate(0,0,-135);
			rtDownLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(laserSpeed, -laserSpeed);
			
			
		}
		//laser down
		if (Input.GetKey(KeyCode.Keypad2) && timer >= shotDelay)
		{
			timer = 0f; // reseting the timer to 0 will make this if statement false so the player can't fire
			musicManager.PlayLaserSound();
			GameObject downLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			downLaser.GetComponent<Transform>().Rotate(0,0,-180);
			downLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -laserSpeed);
			
		}
		//laser down,left
		if (Input.GetKey(KeyCode.Keypad1) && timer >= shotDelay)
		{
			timer = 0f; // reseting the timer to 0 will make this if statement false so the player can't fire
			musicManager.PlayLaserSound();
			GameObject downRtLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			downRtLaser.GetComponent<Transform>().Rotate(0,0,-45);
			downRtLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(-laserSpeed, -laserSpeed);
			
		}
		
		//laser left
		if (Input.GetKey(KeyCode.Keypad4) && timer >= shotDelay)
		{
			timer = 0f; // reseting the timer to 0 will make this if statement false so the player can't fire
			musicManager.PlayLaserSound();
			GameObject leftLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			leftLaser.GetComponent<Transform>().Rotate(0,0,-90);
			leftLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(-laserSpeed, 0);
			
		}
		
		//laser up,left
		if (Input.GetKey(KeyCode.Keypad7) && timer >= shotDelay)
		{
			timer = 0f; // reseting the timer to 0 will make this if statement false so the player can't fire
			musicManager.PlayLaserSound();
			GameObject leftUpLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			leftUpLaser.GetComponent<Transform>().Rotate(0,0,45);
			leftUpLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(-laserSpeed, laserSpeed);
			
		}
	}

	/*
	//this is an alternate way of doing it that isn't as clear to understand
void FireLaser()
	{
		//laser up
		if (Input.GetKey(KeyCode.Keypad8) && Time.time > nextFire) 
		{
			nextFire = Time.time + shotTimer;
			musicManager.PlayLaserSound();
			GameObject upLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			upLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, laserSpeed);
		
		}
		//laser up,right
		if (Input.GetKey(KeyCode.Keypad9) && Time.time > nextFire) 
		{
			nextFire = Time.time + shotTimer;
			musicManager.PlayLaserSound();
			GameObject upRTLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			upRTLaser.GetComponent<Transform>().Rotate(0,0,-45); //rotated the laser -45 degrees
			upRTLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(laserSpeed, laserSpeed); //gave the laser speed to match it's new rotation
			
		}
		
		//laser right
		if (Input.GetKey(KeyCode.Keypad6) && Time.time > nextFire) 
		{
			nextFire = Time.time + shotTimer;
			musicManager.PlayLaserSound();
			GameObject RTLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			RTLaser.GetComponent<Transform>().Rotate(0,0,-90);
			RTLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(laserSpeed, 0);
			
			
		}
		//laser down,right
		if (Input.GetKey(KeyCode.Keypad3) && Time.time > nextFire) 
		{
			nextFire = Time.time + shotTimer;
			musicManager.PlayLaserSound();
			GameObject rtDownLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			rtDownLaser.GetComponent<Transform>().Rotate(0,0,-135);
			rtDownLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(laserSpeed, -laserSpeed);
			
			
		}
		//laser down
		if (Input.GetKey(KeyCode.Keypad2) && Time.time > nextFire) 
		{
			nextFire = Time.time + shotTimer;
			musicManager.PlayLaserSound();
			GameObject downLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			downLaser.GetComponent<Transform>().Rotate(0,0,-180);
			downLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -laserSpeed);
			
		}
		//laser down,left
		if (Input.GetKey(KeyCode.Keypad1) && Time.time > nextFire) 
		{
			nextFire = Time.time + shotTimer;
			musicManager.PlayLaserSound();
			GameObject downRtLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			downRtLaser.GetComponent<Transform>().Rotate(0,0,-45);
			downRtLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(-laserSpeed, -laserSpeed);
			
		}
		
		//laser left
		if (Input.GetKey(KeyCode.Keypad4) && Time.time > nextFire) 
		{
			nextFire = Time.time + shotTimer;
			musicManager.PlayLaserSound();
			GameObject leftLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			leftLaser.GetComponent<Transform>().Rotate(0,0,-90);
			leftLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(-laserSpeed, 0);
			
		}
		
		//laser up,left
		if (Input.GetKey(KeyCode.Keypad7) && Time.time > nextFire) 
		{
			nextFire = Time.time + shotTimer;
			musicManager.PlayLaserSound();
			GameObject leftUpLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			leftUpLaser.GetComponent<Transform>().Rotate(0,0,45);
			leftUpLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(-laserSpeed, laserSpeed);
			
		}
	}

*/
}
