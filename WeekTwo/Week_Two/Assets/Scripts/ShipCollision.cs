using UnityEngine;
using System.Collections;

public class ShipCollision : MonoBehaviour {

	public Color OriginalColor;

	// Use this for initialization
	void Start () {
		//OriginalColor = GetComponent<SpriteRenderer> ().color;
		var sprites = GetComponentsInChildren<SpriteRenderer> ();
		for (int i = 0; i < sprites.Length; i++) {
			sprites [i].color = OriginalColor;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log ("collision!");
		var sprites = GetComponentsInChildren<SpriteRenderer> ();
		for (int i = 0; i < sprites.Length; i++) {
			sprites [i].color = Color.red;
		}
	}

	void OnCollisionExit2D(Collision2D collision)
	{
		var sprites = GetComponentsInChildren<SpriteRenderer> ();
		for (int i = 0; i < sprites.Length; i++) {
			sprites [i].color = OriginalColor;
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Trigger!");
	}
}
