using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Paddle paddle;
	private Vector3 paddleToBall;
	private bool hasStarted = false;
	// Use this for initialization
	void Start () {
		paddleToBall = this.transform.position - paddle.transform.position;
		print (paddleToBall);
	}
	
	// Update is called once per frame
	void Update () {

		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBall;
		}

		if (Input.GetMouseButton (0)) {
			hasStarted = true;
			this.rigidbody2D.velocity = new Vector2(2f,10f);
		}
	}
}
