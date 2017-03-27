using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;

	void Awake(){
		Debug.Log ("Awake method called" + GetInstanceID ());
	}

	// Use this for initialization
	void Start () {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			GameObject.DontDestroyOnLoad (gameObject);
			instance = this;
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
