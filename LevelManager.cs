using UnityEngine;
using System.Collections;


public class LevelManager : MonoBehaviour 
{

	public bool winByEnemyDestruction;
	public bool playerChanceTracker;

	void Update()
	{


		if (winByEnemyDestruction == true) 
		{

			BeatAllBadBotsDetector ();
		}

		if (playerChanceTracker == true) 
		{
			LostAllChancesDetector ();

		}
			
	
	}

	public void LoseChanceAndReset()
	{
		GameManager.playerChances--;
		//had to turn it off because I coudn't reset the enemy count without detecting all enemies were dead
		winByEnemyDestruction = false;
		GameManager.totalEnemyCount = 0;
		Application.LoadLevel (Application.loadedLevel);


		//New API class
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);




	}

	public void NextLevelToLoad()
	{
		Application.LoadLevel (Application.loadedLevel +1);
		//New API class
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoseGame()
	{
		Application.LoadLevel("Lose");
		//New API class
		//SceneManager.LoadScene ("Lose");

	}

	public void PlayGame()
	{

		//GameManager.score = 0;
		GameManager.playerChances = 3;
		//GameManager.totalCoinCount = 0;
		Application.LoadLevel("Game_Level_01");

		//New API class
		//SceneManager.LoadScene ("Game_Level_01");

	}

	public void WinScreen()
	{
		Application.LoadLevel("Win");

		//New API class
		//SceneManager.LoadScene ("Win");
	}

	public void QuitRequest()
	{
		Application.Quit ();
	}

	void BeatAllBadBotsDetector()

	{
		if (GameManager.totalEnemyCount == 0) 
		{
			NextLevelToLoad();
		}
	}

	void LostAllChancesDetector()
	{
		if (GameManager.playerChances == 0) 
		{
			LoseGame();
		}
	}

}
