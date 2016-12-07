using UnityEngine;
using System.Collections;

public class TrailScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        move();
	}

    public void move()
    {
        float moveHorizontal = 0.1f*Input.GetAxis("Horizontal");
        float moveVertical = .1f*Input.GetAxis("Vertical");
        
        if (moveHorizontal != 0) 
        {
            transform.Translate(moveHorizontal, 0, 0);
        }

        if (moveVertical != 0)
        {
            transform.Translate(0, moveVertical, 0);
        }


    }
}
