using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public LevelManager levelManager;

	// Use this for initialization
	void Start () 
	{
		GameManager.score = 0;
		GameManager.totalEnemyCount = 0;
		GameManager.playerChances = 3;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.P)) 
		{
			levelManager.PlayGame ();
		}

		if (Input.GetKeyDown(KeyCode.Q)) 
		{
			levelManager.QuitRequest ();
		}
	}
}
