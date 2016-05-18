using UnityEngine;
using System.Collections;

public class BigBadBot : MonoBehaviour 
{

	public Rigidbody2D badBotRb;
	public float badBotSpeed;
	public LevelManager levelManager;
	public Transform playerTR;
	public float pushBackForce;

	public MusicManager musicManager;


	//public float switchDirection;

	// Use this for initialization
	void Start () 
	{
		GameManager.totalEnemyCount++;
		//InvokeRepeating ("MoveAtPlayer",timeBeforeFirstMove,timeBeforeNextMove);

	}

	// Update is called once per frame
	void Update ()
	{


		//Move Forward - Will move in the red axis of the transform in world space and since the LookAtPlayer funcions always rotates the enemy at player
		// the bad guy will always move forward
		badBotRb.velocity = transform.right * badBotSpeed;
		//will rotate to always face the player
		LookAtPlayer ();


	}

	//this is not intro level scripting so just know that the enemy bot will always rotate to face the player
	void LookAtPlayer()
	{
		Vector3 dir = playerTR.position - transform.position;
		float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}

	//Collision messages
	void OnCollisionEnter2D (Collision2D enemyCollision)
	{
		if (enemyCollision.gameObject.tag == "Player") 
		{
			levelManager.LoseChanceAndReset ();
		} 

		if (enemyCollision.gameObject.tag == "Playfield") 
		{
			musicManager.PlayBigBotDestroyedSound();
			GameManager.score = GameManager.score + 1000;
			GameManager.totalEnemyCount--;
			Destroy (gameObject);

		} 


	}

	//Trigger message that will access the ridgidbody when hit by a laser and force the enemy backward
	void OnTriggerEnter2D(Collider2D laserHit)
	{
		if (laserHit.gameObject.tag == "Laser")
		{
			musicManager.PlayBigBotHitSound();
			GameManager.score = GameManager.score + 20;
			badBotRb.AddRelativeForce (new Vector2 (-pushBackForce,0));

		}

	}
}