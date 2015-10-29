using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float xSpeed;
	public float ySpeed;
	public float maxSpeed;
	public float acceleration;
	public float deceleration;
	private GameObject squareMan;
	private GameObject mainCam;

	public float cameraBoundsX;
	public float cameraBoundsY;
	// Use this for initialization
	void Start () {
		xSpeed = 0;
		ySpeed = 0;
		maxSpeed = 10;
		acceleration = 1.0f;
		deceleration = 0.5f;
		squareMan = gameObject;
		mainCam = GameObject.Find ("Main Camera");

		cameraBoundsX = 6.25f;
		cameraBoundsY = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {

		// Decel
		if (xSpeed < 0) {
			xSpeed += deceleration;
			if (xSpeed >= 0) {
				xSpeed = 0;
			}
		} else if (xSpeed > 0) {
			xSpeed -= deceleration;
			if (xSpeed <= 0) {
				xSpeed = 0;
			}
		}
		if (ySpeed < 0) {
			ySpeed += deceleration;
			if (ySpeed >= 0) {
				ySpeed = 0;
			}
		} else if (ySpeed > 0) {
			ySpeed -= deceleration;
			if (ySpeed <= 0) {
				ySpeed = 0;
			}
		}

		if (Input.GetKey (KeyCode.W)) { //Up
			ySpeed += acceleration;
		}
		if (Input.GetKey (KeyCode.S)) { //Down
			ySpeed -= acceleration;
		}
		if (Input.GetKey (KeyCode.A)) { //Left
			xSpeed -= acceleration;
		}
		if (Input.GetKey (KeyCode.D)) { //Right
			xSpeed += acceleration;
		}

		//Max Speed
		if (maxSpeed > 10) {
			maxSpeed -= 0.01f;
		}

		if (xSpeed >= maxSpeed)  { xSpeed = maxSpeed;  }
		if (ySpeed >= maxSpeed)  { ySpeed = maxSpeed;  }
		if (xSpeed <= -maxSpeed) { xSpeed = -maxSpeed; }
		if (ySpeed <= -maxSpeed) { ySpeed = -maxSpeed; }

		Vector3 newPos = new Vector3 ();
		newPos = transform.position;
		newPos.x += xSpeed * Time.deltaTime;
		newPos.y += ySpeed * Time.deltaTime;

		transform.position = newPos;

		//Camera
		Vector3 camPos = squareMan.transform.position;
		camPos.z = -10;
		if (camPos.x <= -cameraBoundsX) {
			camPos.x = -cameraBoundsX;
		} 
		if (camPos.x >= cameraBoundsX) {
			camPos.x = cameraBoundsX;
		} 
		if (camPos.y <= -cameraBoundsY) {
			camPos.y = -cameraBoundsY;
		} 
		if (camPos.y >= cameraBoundsY) {
			camPos.y = cameraBoundsY;
		} 
		mainCam.transform.position = camPos;

	}
	
}
