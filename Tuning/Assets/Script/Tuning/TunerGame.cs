using UnityEngine;
using UnityEngine.Events;

public class TunerGame : MonoBehaviour
{
    public float Time { get; private set; }
    private bool _timeRunning;

    public UnityEvent StartGameEvent;
    public UnityEvent EndGameEvent;

    private void Start()
    {
        Time = 0;
    }

    private void Update()
    {
        if (_timeRunning) Time += UnityEngine.Time.deltaTime;
    }

    public void StartTimer()
    {
        _timeRunning = true;
    }

    public void EndTimer()
    {
        _timeRunning = false;
    }
}