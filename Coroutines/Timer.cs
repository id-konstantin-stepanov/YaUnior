using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text _text;
    
    private void Start()
    {
        _text.text = "";
        StartCoroutine(Countdown(1));
        Instantiate(_text); // ������ ���, ��� ���� ����?
    }

    private IEnumerator Countdown(float delay, int start = 10)
    {
        var wait = new WaitForSeconds(delay);

        for (int i = start; i > 0; i--)
        {
            DisplayCountdown(i);
            yield return null;
        }
    }

    private void DisplayCountdown(int count)
    {
        _text.text = count.ToString("");
    }
}