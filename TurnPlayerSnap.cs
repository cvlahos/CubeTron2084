using UnityEngine;
using System.Collections;

public class TurnPlayerSnap : MonoBehaviour
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
			//transform.Rotate(0f,0f,rotateSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector3 (0,0,-90f);
		}
		
		if (Input.GetKey(KeyCode.A)) 
		{
			//transform.Rotate(0f,0f,-rotateSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector3 (0,0,90f);
			
		}
	}
}
