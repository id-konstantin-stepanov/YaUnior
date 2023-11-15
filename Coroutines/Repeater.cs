using TMPro;
using UnityEngine;

public class Repeater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay = 2.0f;
    [SerializeField] private float _repeatRate = 2.0f;

    private void Start()
    {
        _text.text = "0";
        InvokeRepeating(nameof(SetCurrentTime), _delay, _repeatRate);
    }

    private void SetCurrentTime()
    {
        _text.text = Time.time.ToString("");
    }
}
