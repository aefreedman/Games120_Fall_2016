using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public Vector3 OriginalPosition;

	// Use this for initialization
	void Start () {
		OriginalPosition = transform.position;
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collision) {
		var sprites = GetComponents<SpriteRenderer> ();
		for (int i = 0; i < sprites.Length; i++) {
			sprites [i].color = Color.red;
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.name == "GreenGoal") {
			transform.position = OriginalPosition;
		}

		if (collider.gameObject.transform.parent.name == "GreenGoal") {
			Debug.Log ("Touched the green goal!");
		}

		if (collider.transform.parent.name == "GreenGoal") {
			Debug.Log ("Touched the green goal! (but differently)");
		}
	}
}
