using UnityEngine;
using System.Collections;

public class StretchSqueeze : MonoBehaviour
{
    private Vector3 _originalScale;
    public Walk WalkScript;
    public float TargetValue;

    private void Start()
    {
        _originalScale = transform.localScale;
    }

    private void Update()
    {
        TargetValue = WalkScript.Speed;
        transform.localScale = _originalScale + new Vector3(Mathf.Abs(TargetValue), Mathf.Clamp(-Mathf.Abs(TargetValue), 0.01f, 0), 0);
    }
}