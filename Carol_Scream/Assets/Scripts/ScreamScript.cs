using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamScript : MonoBehaviour
{

	public AudioSource[] AudioList;



	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) /*&& !audio.isPlaying*/)
		{
			AudioList[0].pitch = Random.Range(.1f, 2f);
			AudioList[0].Play();
		}

		if (Input.GetKeyDown(KeyCode.UpArrow) /*&& !audio.isPlaying*/)
		{
			AudioList[1].pitch = Random.Range(.5f, 1.5f);
			AudioList[1].Play();
		}
		if (Input.GetKeyUp(KeyCode.UpArrow) /*&& !audio.isPlaying*/)
		{
			AudioList[2].pitch = Random.Range(.5f, 1.5f);
			AudioList[2].Play();
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow) /*&& !audio.isPlaying*/)
		{
			AudioList[3].pitch = Random.Range(.2f, 1.5f);
			AudioList[3].Play();
		}
		if (Input.GetKeyDown(KeyCode.RightArrow) /*&& !audio.isPlaying*/)
		{
			AudioList[4].pitch = Random.Range(.5f, 1.5f);
			AudioList[4].Play();
		}
		
		
	}
}
