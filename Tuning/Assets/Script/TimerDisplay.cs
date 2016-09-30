using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour
{

    public TunerGame TunerGame;
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        _text.text = TunerGame.Time.ToString("##.000");
    }
}