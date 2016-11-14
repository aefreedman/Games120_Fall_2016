using UnityEngine;
using System.Collections;

public class DamageFlash : MonoBehaviour {

    public SpriteRenderer render;
    Color initialColor;


    // Use this for initialization
    void Start () {

        initialColor = render.color;
        //playerColor = render.color;
        //redValue = playerColor.r;
        //greenValue = playerColor.g;
        //blueValue = playerColor.b;
        //alphaValue = playerColor.a;
        Debug.Log(render.color);
        

    }
	
	// Update is called once per frame
	void Update () {
        render.color = initialColor;
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //if (col.gameObject.tag == "thing")
        //{
            render.color = new Color(1f, 0, 0);
            Debug.Log(render.color);
        //}
    }

    //void OnCollisionExit2D(Collision2D col)
    //{

    //    redValue = initialColor.r;
    //    greenValue = initialColor.g;
    //    blueValue = initialColor.b;

    //}
}
