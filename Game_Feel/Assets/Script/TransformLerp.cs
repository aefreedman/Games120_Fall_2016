using UnityEngine;
using System.Collections;

public class TransformLerp : MonoBehaviour {

    // animate the game object from -1 to +1 and back
    public float minimum = -1.0F;
    public float maximum =  1.0F;
    private Vector3 _originalPos;

    // starting value for the Lerp    
    static float t = 0.0f;

	// Use this for initialization
	void Start () {
        _originalPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        // animate the position of the game object...
//        transform.position = new Vector3(Mathf.Lerp(minimum, maximum, t), 0, 0);
        transform.position = _originalPos + new Vector3(Mathf.Lerp(minimum, maximum, t), 0, 0);

        // .. and increate the t interpolater
        t += 0.5f * Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > 1.0f){
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
	}
}
