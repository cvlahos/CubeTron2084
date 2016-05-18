using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{
	public float playerSpeed;
	public float laserSpeed;
	public Rigidbody2D playerRB;
	public GameObject laserPrefab;
	public MusicManager musicManager;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		MovePlayer ();
		FireLaser ();

	}


	void MovePlayer()
	{
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			playerRB.velocity = new Vector2 (-playerSpeed * Time.deltaTime, 0);
		} 

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			//playerRB.AddForce (new Vector2 (playerSpeed, 0));
			playerRB.velocity = new Vector2 (playerSpeed * Time.deltaTime, 0);
		} 
	
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			//playerRB.AddForce (new Vector2 (playerSpeed, 0));
			playerRB.velocity = new Vector2 (0, playerSpeed * Time.deltaTime);
		} 

		if (Input.GetKey (KeyCode.DownArrow)) {
			//playerRB.AddForce (new Vector2 (playerSpeed, 0));
			playerRB.velocity = new Vector2 (0, -playerSpeed * Time.deltaTime);
		} 
		// diagionals

		if (Input.GetKey (KeyCode.RightArrow) && Input.GetKey (KeyCode.DownArrow)) 
		{
			//playerRB.AddForce (new Vector2 (playerSpeed, 0));
			playerRB.velocity = new Vector2 (playerSpeed * Time.deltaTime, -playerSpeed * Time.deltaTime);
		} 

		if (Input.GetKey (KeyCode.RightArrow) && Input.GetKey (KeyCode.UpArrow)) 
		{
			//playerRB.AddForce (new Vector2 (playerSpeed, 0));
			playerRB.velocity = new Vector2 (playerSpeed * Time.deltaTime, playerSpeed * Time.deltaTime);
		} 

		if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKey (KeyCode.UpArrow)) 
		{
			//playerRB.AddForce (new Vector2 (playerSpeed, 0));
			playerRB.velocity = new Vector2 (-playerSpeed * Time.deltaTime, playerSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKey (KeyCode.DownArrow)) 
		{
			//playerRB.AddForce (new Vector2 (playerSpeed, 0));
			playerRB.velocity = new Vector2 (-playerSpeed * Time.deltaTime, -playerSpeed * Time.deltaTime);
		} 
	}

	//Instead of having 8 different prefabs for each laser direction there is a more efficient way to instantiate as a game object where we can get control of components


	void FireLaser()
	{
		//laser up
		if (Input.GetKeyDown(KeyCode.Keypad8)) 
		{
			musicManager.PlayLaserSound();
			GameObject upLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			upLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, laserSpeed);
		
		}
		//laser up,right
		if (Input.GetKeyDown(KeyCode.Keypad9)) 
		{
			musicManager.PlayLaserSound();
			GameObject upRTLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			upRTLaser.GetComponent<Transform>().Rotate(0,0,-45); //rotated the laser -45 degrees
			upRTLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(laserSpeed, laserSpeed); //gave the laser speed to match it's new rotation
			
		}
		
		//laser right
		if (Input.GetKeyDown(KeyCode.Keypad6)) 
		{
			musicManager.PlayLaserSound();
			GameObject RTLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			RTLaser.GetComponent<Transform>().Rotate(0,0,-90);
			RTLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(laserSpeed, 0);
			
			
		}
		//laser down,right
		if (Input.GetKeyDown(KeyCode.Keypad3)) 
		{
			musicManager.PlayLaserSound();
			GameObject rtDownLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			rtDownLaser.GetComponent<Transform>().Rotate(0,0,-135);
			rtDownLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(laserSpeed, -laserSpeed);
			
			
		}
		//laser down
		if (Input.GetKeyDown(KeyCode.Keypad2)) 
		{
			musicManager.PlayLaserSound();
			GameObject downLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			downLaser.GetComponent<Transform>().Rotate(0,0,-180);
			downLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -laserSpeed);
			
		}
		//laser down,left
		if (Input.GetKeyDown(KeyCode.Keypad1)) 
		{
			musicManager.PlayLaserSound();
			GameObject downRtLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			downRtLaser.GetComponent<Transform>().Rotate(0,0,-45);
			downRtLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(-laserSpeed, -laserSpeed);
			
		}
		
		//laser left
		if (Input.GetKeyDown(KeyCode.Keypad4)) 
		{
			musicManager.PlayLaserSound();
			GameObject leftLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			leftLaser.GetComponent<Transform>().Rotate(0,0,-90);
			leftLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(-laserSpeed, 0);
			
		}
		
		//laser up,left
		if (Input.GetKeyDown(KeyCode.Keypad7)) 
		{
			musicManager.PlayLaserSound();
			GameObject leftUpLaser =  Instantiate (laserPrefab, transform.position, transform.rotation) as GameObject;
			leftUpLaser.GetComponent<Transform>().Rotate(0,0,45);
			leftUpLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(-laserSpeed, laserSpeed);
			
		}
	}

}
