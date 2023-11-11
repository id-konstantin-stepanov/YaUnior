using System.Collections;
using UnityEngine;

public class ColorAndRotationChanger : MonoBehaviour
{
    [SerializeField] private Color _startColor = Color.red;
    [SerializeField] private Color _endColor = Color.green;
    [SerializeField] private float _duration = 3.0f;

    private Material _material;

    private void Start()
    {
        _material = GetComponent<Renderer>().material;
        StartCoroutine(ChangeColor(_material));
    }

    private IEnumerator ChangeColor(Material material)
    {
        float time = 0.0f;

        while (time < _duration)
        {
            time += Time.deltaTime;
            material.color = Color.Lerp(_startColor, _endColor, time / _duration);
            yield return null;
        }

        StartCoroutine(Rotate());
    }

    private IEnumerator Rotate()
    {
        while (true)
        {
            transform.Rotate(new Vector3(1.0f, 0.5f, 0.0f));
            yield return null;
        }
    }
}
