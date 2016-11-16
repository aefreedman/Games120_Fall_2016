using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MakeNumbers : MonoBehaviour {

	public GameObject numbers;
	private GameObject numbersNow;
	private Vector2 force;

	// Use this for initialization
	void Start () {
		force = new Vector2 (150, 500);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void MakeNumber (Vector3 Position, string text){
		numbersNow = Instantiate (numbers, Position,Quaternion.identity) as GameObject;
		numbersNow.transform.SetParent (gameObject.transform);
		numbersNow.GetComponent<Text> ().text = text;
		numbersNow.GetComponent<Rigidbody2D> ().AddForce (force);
	}
}
