// ScreenShake.cs
// Last edited 5:35 PM 04/21/2015 by Aaron Freedman

using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    private float activeTime;
    private Transform camPos;
    private float intensity;
    private Vector3 originalPosition;
    public bool shake;
    public bool useLerp;
    private float startTime;
    private Vector3 target;

    //TODO: this screenshake method doesn't work for movable cameras attached to an object

    private void Start ()
    {
        originalPosition = Camera.main.gameObject.transform.position;
        camPos = GetComponent<Camera> ().gameObject.transform;
        target = originalPosition;
        shake = false;
    }

    private void Update ()
    {
        if (shake)
        {
            if (Time.time > startTime + activeTime)
            {
                StopShake ();
            } else
            {
                Shake ();
            }
        }

        camPos.position = useLerp ? Vector3.Lerp (camPos.position, target, 10 * Time.deltaTime) : target;
    }

    public void Shake ()
    {
        target = new Vector3 (originalPosition.x + Random.Range (-intensity, intensity),
                                 originalPosition.y + Random.Range (-intensity, intensity), originalPosition.z);
    }

    public void StartShake (float time, float _intensity)
    {
        shake = true;
        activeTime = time;
        startTime = Time.time;
        intensity = _intensity;
    }

    public void StopShake ()
    {
        ResetPosition ();
    }

    public void ResetPosition ()
    {
        target = originalPosition;
    }
}