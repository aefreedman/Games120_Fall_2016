using UnityEngine;
using System.Collections;

public class TypeWriterText : MonoBehaviour {

    public Text textBox;
    public string[] text;
    public int textDisplay = 0;
	// Use this for initialization
	void Start () {
        StartCoroutine(AnimateText());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //skips the currently displayed text (to be used with a button press) 
    void SkipText ()
    {
        StopAllCoroutines();
        textDisplay++;
        if(textDisplay > text.Length) //as of now this just loops the text
        {
            textDisplay = 0;
        }
        StartCoroutine(AnimateText());
    }

    //does typewriter text
    IEnumerator AnimateText()
    {
        for(int i = 0; i < text[textDisplay].Length + 1; i++)
        {
            textDisplayed.text = text[textDisplay].Substring(0, i);
            yield return new WaitForSeconds(.2f);
        }
    }
}
