using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private float _acceleration;
    private float _brakeForce;
    private float _force;
    private float _maxAngularVelocityForTurn;
    private float _maxForce;
    private float _turnForce;
    public Rigidbody2D Rigidbody2D;

    private void Start()
    {
        if (!Rigidbody2D) Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void SetTuningValues(float accel, float maxForce, float brake, float mass, float linearDrag, float turnForce,
        float angularDrag, float maxAngularVel)
    {
        _acceleration = accel;
        _brakeForce = brake;
        Rigidbody2D.drag = linearDrag;
        Rigidbody2D.mass = mass;
        _maxForce = maxForce;
        _turnForce = turnForce;
        Rigidbody2D.angularDrag = angularDrag;
        _maxAngularVelocityForTurn = maxAngularVel;
    }

    private void Update()
    {
    }

    private Vector2 TurnMode()
    {
        var vertical = Input.GetAxis("Vertical");
        if (vertical > 0)
        {
            if (_force < _maxForce) _force += _acceleration;
            else _force = _maxForce;
        }
        else if (vertical < 0 && Rigidbody2D.velocity.y > 0)
        {
            _force = Mathf.Clamp(-_brakeForce, 0, Rigidbody2D.velocity.magnitude);
        }
        else
        {
            _force = 0;
        }

        if (Input.GetButton("Horizontal"))
        {
            if (Mathf.Abs(Rigidbody2D.angularVelocity) < _maxAngularVelocityForTurn)
                Rigidbody2D.AddTorque(-Input.GetAxis("Horizontal")*_turnForce);
        }
        return new Vector2(0, _force);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.AddRelativeForce(TurnMode(), ForceMode2D.Force);
    }
}