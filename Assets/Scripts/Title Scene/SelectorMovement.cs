using UnityEngine;
using System.Collections;

public class SelectorMovement : MonoBehaviour
{
	private AudioSource audioSrc;
	public AudioClip audioClip;

	public Vector2 startGamePos;
	public Vector2 optionsPos;
	public Vector2 quitPos;
	public int selectorPos;
	// Use this for initialization
	void Start ()
	{
		audioSrc = GetComponent<AudioSource> ();
		selectorPos = 0;
		startGamePos = transform.position;
		optionsPos = new Vector2 (transform.position.x, transform.position.y - 40);
		quitPos = new Vector2 (transform.position.x, transform.position.y - 80);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.S)) {
			audioSrc.PlayOneShot(audioClip);
			switch (selectorPos) {
			case 0: transform.position = optionsPos; 	selectorPos = 1; break;
			case 1: transform.position = quitPos; 		selectorPos = 2; break;
			case 2: transform.position = startGamePos; 	selectorPos = 0; break;
			}
		} else if (Input.GetKeyDown(KeyCode.W)) {
			audioSrc.PlayOneShot(audioClip);
			switch (selectorPos) {
			case 0: transform.position = quitPos; 		selectorPos = 2; break;
			case 1: transform.position = startGamePos; 	selectorPos = 0; break;
			case 2: transform.position = optionsPos; 	selectorPos = 1; break;
			}
		}

		if (Input.GetKeyDown (KeyCode.Return)) {
			switch (selectorPos) {
			case 0 : //Start Game
				Application.LoadLevel("Main");
				break;
			case 1: //Options
				break;
			case 2: //Quit
				Application.Quit();
				break;
			}
		}
	}
}

