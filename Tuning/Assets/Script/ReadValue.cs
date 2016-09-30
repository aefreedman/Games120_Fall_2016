using UnityEngine;
using UnityEngine.UI;

public class ReadValue : MonoBehaviour
{
    public Component Obj;
    private Text _text;

    private void Start()
    {
    }

    private void Update()
    {
        _text.text = Obj.name;
    }
}