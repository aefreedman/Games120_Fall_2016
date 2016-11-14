using UnityEngine;
using System.Collections;

public class HitPause : MonoBehaviour {

	public bool hitPause;
	public float stopTime;
	public float originalTimeScale;



	void Start () {
		originalTimeScale = Time.timeScale;
		hitPause = false;
		//MODIFY THIS FOR YOUR NEEDS
		//stopTime = .5f; 
	}
	

	void Update () {
		//CREATE PARAMETERS FOR HITPAUSE = TRUE
		//if (Input.GetKeyDown("a")) {
		//	hitPause = true;
		//}
		if (hitPause) {
			StartCoroutine ("Pause");
			hitPause = false;
		}
	}



	IEnumerator Pause () {
		//STOPS TIME
		Time.timeScale = 0;

		//WAITS FOR STOPTIME SECONDS BEFORE CONTINUING
		yield return new WaitForSecondsRealtime(stopTime);

		//RESETS TIME BACK TO WHAT IT WAS AT START
		Time.timeScale = originalTimeScale;
		
	}


}



