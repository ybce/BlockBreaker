using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public int max_hits = 0;
	private int times_hit;
	public BreakerController breakerController;
	// Use this for initialization
	void Start () {
		times_hit = 0;

	}

	void OnCollisionEnter2D(Collision2D collision){

		times_hit++;
		if (times_hit == max_hits) {
			breakerController.detectDestruction();
			Destroy(this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {


	}
}
