using UnityEngine;
using System.Collections;

public class ParticleMovement: MonoBehaviour {

	// Use this for initialization
	public float speed;

	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
	{
		float newX = transform.position.x + speed;
		Vector2 newPos = new Vector2 (newX, transform.position.y);
		transform.position = newPos;
		if (transform.position.x >= 12) {
			Destroy(gameObject);
		}
	}
	
}
