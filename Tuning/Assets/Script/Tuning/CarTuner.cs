using UnityEngine;

public class CarTuner : MonoBehaviour
{
    public Car MyCar;
    public CarMovement MyCarMovement;

    [Header("Tuning Values")]
    public float TurningRate;
    public float MaxAngularVelocity;
    public float BrakeStrength;
    public float Acceleration;
    public float MaxAcceleration;
    public float LinearDrag;
    public float AngularDrag;
    public float Mass;

    private void Start()
    {
        SendTuningValues();
    }

    public void SendTuningValues()
    {
        MyCarMovement.SetTuningValues(Acceleration, MaxAcceleration, BrakeStrength, Mass, LinearDrag, TurningRate,
            AngularDrag, MaxAngularVelocity);
    }

}