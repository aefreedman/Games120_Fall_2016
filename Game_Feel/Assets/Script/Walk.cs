using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour {

    public float Speed;
    public float Multiplier;

	// Use this for initialization
	void Start () {
        Speed = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton ("Horizontal")) {
            var direction = Input.GetAxis ("Horizontal");
            if (direction < 0) {
                Speed = Speed - Time.deltaTime * Multiplier;
            }
            if (direction > 0) {
                Speed = Speed + Time.deltaTime * Multiplier;
            }
        }
        if (Input.GetButtonUp("Horizontal"))
        {
            Speed = 0;
        }

        transform.Translate(new Vector3(Speed, 0, 0));
	}
}
