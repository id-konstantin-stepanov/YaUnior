using UnityEngine;
using UnityEngine.UI;

public class Repeater : MonoBehaviour
{
    [SerializeField] private Text _text;

    private float _delay = 10.0f;
    private float _repeatTime = 10.0f;

    private void Start()
    {
        InvokeRepeating(nameof(SetCurrentTime), _delay, _repeatTime);
    }

    private void SetCurrentTime()
    {
        _text.text = Time.time.ToString("");
    }
}