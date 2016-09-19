using UnityEngine;
using System.Collections;

public class MyFirstUnityScript : MonoBehaviour {

    public float AFloat;
    private float _privateFloat;
    public bool ABool;
    public float[] AFloatArray;

	// Use this for initialization
	void Start () 
    {
        AFloatArray = new float[] {1, 2, 3, 4};
        var sprite = gameObject.GetComponent<SpriteRenderer>();
            sprite.color = new Color(0f, 0f, 0f);
        var collider = gameObject.GetComponent<BoxCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (ABool)
            transform.Rotate(0, 1f, 1f);
	}
        
}
