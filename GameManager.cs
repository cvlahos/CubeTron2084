using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public static int playerChances = 3;
	public static int totalEnemyCount;
	public static int score;


	public Text myChancesleft;
	public Text myScore;


	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{


		myScore.text = score.ToString ();
		myChancesleft.text = "Chances Left  " + playerChances.ToString ();
		//Debug.Log (score);
		//Debug.Log (totalEnemyCount);
	}
}
