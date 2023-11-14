using UnityEngine;
using UnityEngine.UI;

public class Chronometr : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _delay = 10.0f;

    private float _triggerTime;

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