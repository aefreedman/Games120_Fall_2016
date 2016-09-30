using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{

    public string ReloadButtonName;

	void Start () {
	
	}
	
	void Update ()
	{
	    if (Input.GetButton(ReloadButtonName))
	        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
