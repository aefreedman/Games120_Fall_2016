using UnityEngine;

public class CarBoundaryCheck : MonoBehaviour
{
    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.name == "Track")
        {
            Debug.Log("Out of bounds!");
            GetComponentInParent<Car>().Reset();
        }
    }
}