using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
	private PlayerMovement movement;

	void Start() {
		movement = gameObject.GetComponent<PlayerMovement> ();
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Gem") {

			Destroy(col.gameObject);
			gameObject.GetComponent<SpriteRenderer>().color = col.gameObject.GetComponent<SpriteRenderer>().color;
			movement.maxSpeed += 3.0f;
			movement.acceleration += 0.1f;

		}

		if (col.gameObject.tag == "Vertical Wall") {
			gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
			movement.xSpeed = 0;
		}
		if (col.gameObject.tag == "Horizontal Wall") {
			gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
			movement.ySpeed = 0;
		}

	}
}

