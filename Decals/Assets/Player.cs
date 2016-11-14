using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    Vector3 move;
	// Use this for initialization
	void Start () {
        move = new Vector3(-.09f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey("left"))
        {
            transform.position = transform.position + move;
        }
        if (Input.GetKey("right"))
        {
            transform.position = transform.position - move;
        }
        if(Input.GetKey("up"))
        {
            transform.position = transform.position + Vector3.up*.1f;
        }

    }
}
