using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay = 2.0f;

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
