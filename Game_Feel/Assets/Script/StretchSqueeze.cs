using UnityEngine;
using System.Collections;

public class StretchSqueeze : MonoBehaviour {
    
    private Vector3 _originalScale;
    public Walk WalkScript;
    public float TargetValue;

	// Use this for initialization
	void Start () {
        _originalScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
        TargetValue = WalkScript.Speed;
        transform.localScale = _originalScale + new Vector3(Mathf.Abs(TargetValue), -Mathf.Abs(TargetValue), 0);
	}
}
