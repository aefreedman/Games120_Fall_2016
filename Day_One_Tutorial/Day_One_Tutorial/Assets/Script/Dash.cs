using UnityEngine;
using System.Collections;

public class Dash : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Dash"))
            transform.Translate(new Vector3(-1f, 0, 0));
        if (Input.GetButtonDown("DashRight"))
            transform.Translate(new Vector3(1f, 0, 0));
        
	
	}
}
