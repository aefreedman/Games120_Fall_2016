using UnityEngine;
using System.Collections;

public class ScreenShake_VelocityBased : MonoBehaviour 
{
    //Script that causes screen shake based upon velocity of a collision

	Vector3 originalCameraPosition;
	float shakeAmt = 0;
	public Camera mainCamera;

    public float shakeMultiplier;

	void Start() {
		originalCameraPosition = mainCamera.transform.position;
        shakeMultiplier = .0025f; //can be whatever works best based upon avg speed of your collisions.
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		shakeAmt = coll.relativeVelocity.magnitude * shakeMultiplier;
		InvokeRepeating("CameraShake", 0, .01f);
		Invoke("StopShaking", 0.3f);

	}

	void CameraShake()
	{
		if(shakeAmt>0) 
		{
			float quakeAmt = Random.value*shakeAmt*2 - shakeAmt;
			Vector3 tempPosition = mainCamera.transform.position;
            tempPosition.y += quakeAmt; // can also add to x and/or z
			mainCamera.transform.position = tempPosition;
		}
	}

	void StopShaking()
	{
		CancelInvoke("CameraShake");
		mainCamera.transform.position = originalCameraPosition;
	}

}