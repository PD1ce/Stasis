using UnityEngine;
using System.Collections;

public class BulletTravel : MonoBehaviour
{

	// Use this for initialization
	public float bulletSpeed;
	public Vector2 direction;
	private int count;

	void Start ()
	{
		count = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector2 newPos = transform.position;
		newPos.x += direction.x;
		newPos.y += direction.y;
		transform.position = newPos;
		count++;

		if (count > 300) {
			Destroy(gameObject);
		}



	}
}

