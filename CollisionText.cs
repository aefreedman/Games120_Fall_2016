using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollisionText : MonoBehaviour {

	private int collisionCounter;
	public GameObject canvas;


	// Use this for initialization
	void Start () {
		collisionCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		collisionCounter++;
		canvas.GetComponent<MakeNumbers>().MakeNumber (GetComponent<Transform> ().position, collisionCounter.ToString ());
	}
}
