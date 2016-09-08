using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

    [Range(-1, 1f)]
    public float GravityStrength;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, GravityStrength, 0));
	}
}
