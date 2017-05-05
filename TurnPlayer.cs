using UnityEngine;
using System.Collections;

public class TurnPlayer : MonoBehaviour
{
	public float rotateSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.D)) 
		{
			transform.Rotate(0f,0f,rotateSpeed * Time.deltaTime);	
		}
		
		if (Input.GetKey(KeyCode.A)) 
		{
			transform.Rotate(0f,0f,-rotateSpeed * Time.deltaTime);
			
		}
	}
}
