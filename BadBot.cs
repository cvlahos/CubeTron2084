using UnityEngine;
using System.Collections;

public class BadBot : MonoBehaviour 
{

	public Rigidbody2D badBotRb;
	public float badBotSpeed;
	public float timeBeforeFirstMove;
	public float timeBeforeNextMove;



	public LevelManager levelManager;

	public Transform playerTR;

	public MusicManager musicManager;




	// Use this for initialization
	void Start () 
	{
		GameManager.totalEnemyCount++;
		InvokeRepeating ("MoveAtPlayer",timeBeforeFirstMove,timeBeforeNextMove);

	}

	// Update is called once per frame
	void Update ()
	{


		LookAtPlayer ();
			
	}

	void MoveAtPlayer()
	{
		

		int badBotAttack = Random.Range (1,6);

		if (badBotAttack == 1)
		{
			//Move Forward - Will move in the red axis of the transform in world space and since the LookAtPlayer funcions always rotates the enemy at player
			// the bad guy will always move forward
			badBotRb.velocity = transform.right * badBotSpeed;


		}

		if (badBotAttack == 2)
		{
			//Move Forward - Will move in the red axis of the transform in world space and since the LookAtPlayer funcions always rotates the enemy at player
			// the bad guy will always move forward
			badBotRb.velocity = transform.right * badBotSpeed;

		}

		if (badBotAttack == 3)
		{
			//Move Back - Will move in the red axis of the transform in world space and since the LookAtPlayer funcions always rotates the enemy at player
			// the bad guy will always move back because of the - speed variable
			badBotRb.velocity = transform.right * -badBotSpeed;

		}

		if (badBotAttack == 4)
		{
			//Move Left The green axis of the transform in world space.
			badBotRb.velocity = transform.up * badBotSpeed;

		
		}

		if (badBotAttack == 5)
		{
			//Move Right The green axis of the transform in world space.
			badBotRb.velocity = transform.up * -badBotSpeed;


		}
		//Debug.Log (badBotAttack);
	}

	//this is not intro level scripting so just know that the enemy bot will always rotate to face the player
	void LookAtPlayer()
	{
		Vector3 dir = playerTR.position - transform.position;
		float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}


	void OnCollisionEnter2D (Collision2D enemyCollision)
	{
		if (enemyCollision.gameObject.tag == "Player") 
		{

			levelManager.LoseChanceAndReset ();
		
		} 
			
	
	}

	void OnTriggerEnter2D(Collider2D laserHit)

	{


		if (laserHit.gameObject.tag == "Laser")
		{
			musicManager.PlayBigBotDestroyedSound();
			GameManager.score = GameManager.score + 200;
			GameManager.totalEnemyCount--;
			Destroy (gameObject);
		}


	}
	

}
