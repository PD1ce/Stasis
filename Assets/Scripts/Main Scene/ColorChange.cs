using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

	public Color color;
	public int randomColor;

	public SpriteRenderer spriteRend;

	void Start() {
		spriteRend = gameObject.GetComponent<SpriteRenderer> ();
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			randomColor = Random.Range(0, 7);
			switch (randomColor) {
			case 0: spriteRend.color = Color.black; break;
			case 1: spriteRend.color = Color.blue; break;
			case 2: spriteRend.color = Color.cyan; break;
			case 3: spriteRend.color = Color.green; break;
			case 4: spriteRend.color = Color.red; break;
			case 5: spriteRend.color = Color.yellow; break;
			case 6: spriteRend.color = Color.white; break;
			}
		}
	}
}