using UnityEngine;
using System.Collections;

public class GemGenerator : MonoBehaviour
{
	public int spawnTime;
	public int count;
	public Transform gem;

	// Use this for initialization
	void Start ()
	{
		spawnTime = 20;
		count = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		count++;
		if (count >= spawnTime) {
			Vector2 vec = genRandomPosition();
			gem.GetComponent<SpriteRenderer>().color = genRandomColor();
			count = 0;
			//GameObject newGem = Instantiate(gem, vec, Quaternion.identity) as GameObject; 
		}
	}

	Vector2 genRandomPosition() {
		float xPos = Random.Range (-8.0f, 14.5f);
		float yPos = Random.Range (-7.0f, 7.0f);
		return new Vector2(xPos, yPos);
	}

	Color genRandomColor() {
		Color col = new Color ();
		int rand = Random.Range (0, 7);
		switch (rand) {
		case 0:
			col = Color.magenta;
			break;
		case 1:
			col = Color.blue;
			break;
		case 2:
			col = Color.cyan;
			break;
		case 3:
			col = Color.green;
			break;
		case 4:
			col = Color.red;
			break;
		case 5:
			col = Color.yellow;
			break;
		case 6:
			col = Color.white;
			break;
		}
		return col;
	}
}

