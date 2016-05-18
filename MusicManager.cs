using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour 
{
	public AudioClip laserSoundClip;
	public float laserSoundVolume;

	public AudioClip bigBotHitClip;
	public float bigBotVolume;

	public AudioClip bigBotDestroyedClip;
	public float bigBotDestroyedVolume;






	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void PlayLaserSound()
	{
		AudioSource.PlayClipAtPoint (laserSoundClip,transform.position,laserSoundVolume);
	}

	public void PlayBigBotHitSound()
	{
		AudioSource.PlayClipAtPoint (bigBotHitClip,transform.position);
	}

	public void PlayBigBotDestroyedSound()
	{
		AudioSource.PlayClipAtPoint (bigBotDestroyedClip,transform.position);

	}


}
