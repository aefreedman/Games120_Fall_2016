using UnityEngine;
using System.Collections;

public class Sonic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Sonic crash!");
        if (col.gameObject.name == "Ground"){}
//            transform.Translate(new Vector3(0, 4f, 0));
        else if (col.gameObject.name == "Ring")
        {
            col.gameObject.SetActive(false);
            Debug.Log("sdhsdh");
            var s = GetComponent<AudioSource>();

            s.PlayOneShot(s.clip);
        }

    }
}
