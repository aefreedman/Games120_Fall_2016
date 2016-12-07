using UnityEngine;
using System.Collections;

public class CloudMove : MonoBehaviour {


	public GameObject character;
	public Vector3 cloudPos;
	public float offset;
	public float xfix;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		cloudPos = new Vector3 ((character.transform.position.x*offset)+xfix,transform.position.y,character.transform.position.z);
		transform.position = cloudPos;
	}
}
