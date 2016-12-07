using UnityEngine;
using System.Collections;

public class Decals : MonoBehaviour {
    public GameObject decal;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        Vector2 hitPoint = transform.position;
        if (coll.gameObject.tag == "wall")
        {
            foreach (ContactPoint2D decalPlace in coll.contacts)
            {
                hitPoint = (hitPoint + decalPlace.point)/2;

            }
            Instantiate(decal, new Vector3(hitPoint.x, hitPoint.y, 0), Quaternion.identity);
        }
    }
}
