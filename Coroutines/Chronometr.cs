using UnityEngine;
using UnityEngine.UI;

public class Chronometr : MonoBehaviour
{
    [SerializeField] private Text _text;

    private float _triggerTime;
    private float _delay = 10.0f;

    private void Start()
    {
        _triggerTime = _delay;
        _text.text = "0";
    }

    private void Update()
    {
        if (Time.time >= _triggerTime)
        {
            _text.text = Time.time.ToString("");
            _triggerTime = Time.time + _delay;
        }
    }
}