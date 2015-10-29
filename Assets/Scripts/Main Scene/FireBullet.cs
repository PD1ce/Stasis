using UnityEngine;
using System.Collections;

public class FireBullet : MonoBehaviour
{
	public GameObject bullet;
	public float fireRate;
	public float bulletSpeed;
	private float nextFire;
	private float xSpeed;
	private float ySpeed;

	public float divisibleMovement;
	// Use this for initialization
	void Start ()
	{
		fireRate = 0.25f;
		nextFire = 0.0f;
		bulletSpeed = 0.3f;
		//xSpeed = gameObject.GetComponent<PlayerMovement> ().xSpeed;
		//ySpeed = gameObject.GetComponent<PlayerMovement> ().ySpeed;

		divisibleMovement = 50.0f;
		//Debug.Log (ySpeed);

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			xSpeed = gameObject.GetComponent<PlayerMovement> ().xSpeed;
			GameObject newBullet = Instantiate (bullet, transform.position, Quaternion.identity) as GameObject;
			newBullet.AddComponent<BulletTravel> ();
			newBullet.GetComponent<BulletTravel> ().bulletSpeed = bulletSpeed;
			newBullet.GetComponent<BulletTravel> ().direction = new Vector2(xSpeed / divisibleMovement, bulletSpeed);

			//Debug.Log (xSpeed);

		} else if (Input.GetKey (KeyCode.LeftArrow) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			ySpeed = gameObject.GetComponent<PlayerMovement> ().ySpeed;
			GameObject newBullet = Instantiate (bullet, transform.position, Quaternion.identity) as GameObject;
			newBullet.AddComponent<BulletTravel> ();
			newBullet.GetComponent<BulletTravel> ().bulletSpeed = bulletSpeed;
			newBullet.GetComponent<BulletTravel> ().direction = new Vector2(-bulletSpeed, ySpeed / divisibleMovement);
		
			//Debug.Log (ySpeed);
		} else if (Input.GetKey (KeyCode.DownArrow) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			xSpeed = gameObject.GetComponent<PlayerMovement> ().xSpeed;
			GameObject newBullet = Instantiate (bullet, transform.position, Quaternion.identity) as GameObject;
			newBullet.AddComponent<BulletTravel> ();
			newBullet.GetComponent<BulletTravel> ().bulletSpeed = bulletSpeed;
			newBullet.GetComponent<BulletTravel> ().direction = new Vector2(xSpeed / divisibleMovement, -bulletSpeed);

			//Debug.Log (xSpeed);
		} else if (Input.GetKey (KeyCode.RightArrow) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			ySpeed = gameObject.GetComponent<PlayerMovement> ().ySpeed;
			GameObject newBullet = Instantiate (bullet, transform.position, Quaternion.identity) as GameObject;
			newBullet.AddComponent<BulletTravel> ();
			newBullet.GetComponent<BulletTravel> ().bulletSpeed = bulletSpeed;
			newBullet.GetComponent<BulletTravel> ().direction = new Vector2(bulletSpeed, ySpeed / divisibleMovement);

			//Debug.Log (ySpeed);
		}
	}
}

