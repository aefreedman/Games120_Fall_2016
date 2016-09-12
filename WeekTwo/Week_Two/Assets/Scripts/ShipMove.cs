using UnityEngine;
using System.Collections;

public class ShipMove : MonoBehaviour {

	public float Speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Taunt")) {
			var allSprites = GetComponentsInChildren<SpriteRenderer> ();
			for (int i = 0; i < allSprites.Length; i++) {
				allSprites [i].color = Color.blue;
			}
		}
		if (Input.GetButtonUp ("Taunt")) {
			var allSprites = GetComponentsInChildren<SpriteRenderer> ();
			for (int i = 0; i < allSprites.Length; i++) {
				allSprites [i].color = Color.white;
			}
		}

		if (Input.GetButton ("Horizontal")) {
			var direction = Input.GetAxis ("Horizontal");
			if (direction < 0) {
				transform.Translate (Vector2.left * Speed, Space.World);
			}
			if (direction > 0) {
				transform.Translate (Vector2.right * Speed, Space.World);
			}
		}
		if (Input.GetButton ("Vertical")) {
			var direction = Input.GetAxis ("Vertical");
			if (direction < 0) {
				transform.Translate (Vector2.down * Speed, Space.World);
			}
			if (direction > 0) {
				transform.Translate (Vector2.up * Speed, Space.World);
			}
		}
	}
}
