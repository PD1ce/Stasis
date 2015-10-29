using UnityEngine;
using System.Collections;

public class ParticleGeneration: MonoBehaviour {

	// Use this for initialization
	public GameObject particle;
	public int count;
	public int spawnTime;

	void Start () {
		count = 0;
		spawnTime = 10;
	}
	
	// Update is called once per frame
	void Update ()
	{
		count++;
		if (count >= spawnTime) {
			Vector2 vec = genRandomPosition();
			float speed = Random.Range (0.05f, 0.15f);
			count = 0;
			//Probably can make a constructor or something to handle all this

			GameObject newParticle = Instantiate(particle, vec, Quaternion.identity) as GameObject; 
			newParticle.AddComponent<ParticleMovement>();
			newParticle.GetComponent<ParticleMovement>().speed = speed;
			//Debug.Log("Instantiated a new particle");

		}
	}

	Vector2 genRandomPosition() {
		float xPos = -12.0f;
		float yPos = Random.Range (-4.9f, 4.9f);
		return new Vector2(xPos, yPos);
	}
}
