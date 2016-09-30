using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CarMovement))]
public class Car : MonoBehaviour
{
    private Vector3 _originVector3;
    private Quaternion _originQuaternion;
    public CarTuner Tuner;
    public TunerGame GameManager;

    private int _pickups;
    private int _pickupsNeeded = 3;

    private void Start()
    {
        _originVector3 = transform.position;
        _originQuaternion = transform.rotation;
    }

    public void Reset()
    {
        transform.position = _originVector3;
        transform.rotation = _originQuaternion;
        var rbody = GetComponent<Rigidbody2D>();
        rbody.angularVelocity = 0;
        rbody.velocity = Vector2.zero;

        Tuner.SendTuningValues();
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "StartFinish")
        {
            if (_pickups >= _pickupsNeeded) GameManager.EndGameEvent.Invoke();
            else GameManager.StartGameEvent.Invoke();
        }

        if (collider.name == "Pickup")
        {
            _pickups++;
            collider.gameObject.SetActive(false);
        }
    }
}