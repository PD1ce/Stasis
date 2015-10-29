using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
	public float maxZoom;
	public float minZoom;
	public float zoom;
	public Camera cam;
	 
	void Start ()
	{
		minZoom = 2.0f;
		maxZoom = 10.0f;
		cam = gameObject.GetComponent<Camera> ();
		zoom = cam.orthographicSize;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.Q)) { // Zoom in
			zoom -= 0.1f;
		}
		if (Input.GetKey(KeyCode.E)) { // Zoom out
			zoom += 0.1f;
		}

		// Min and max
		if (zoom <= minZoom) { zoom = minZoom; }
		if (zoom >= maxZoom) { zoom = maxZoom; }

		cam.orthographicSize = zoom;

	}
}

