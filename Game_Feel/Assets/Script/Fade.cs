using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {
    int timer;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer++;
    if (timer == 260)
        {
            Destroy(gameObject);
        }

	}
}
