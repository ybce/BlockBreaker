using UnityEngine;
using System.Collections;

public class BreakerController : MonoBehaviour {
	public LevelManager levelManager;
	public int score = 48;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (score);
		if (score == 0) {
			levelManager.LoadLevel("Win Screen");
		}
	}

	public void detectDestruction(){
		score --;
	}

}