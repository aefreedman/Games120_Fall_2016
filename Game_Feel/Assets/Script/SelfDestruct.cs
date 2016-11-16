using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	private float time;
	private float current;

	// Use this for initialization
	void Start () {
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		current = Time.time;
		if ((current - time) > 2) {
			Destroy (gameObject);
		}
	}
}
