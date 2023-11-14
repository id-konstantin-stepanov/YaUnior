using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition = new Vector3(-2.5f, 0, 0);
    [SerializeField] private Vector3 _endPosition = new Vector3(2.5f, 0, 0);
    [SerializeField] private int _stepsCount = 10;

    private void Start()
    {
        foreach (Vector3 position in EnumeratePositions(_startPosition, _endPosition, _stepsCount))
        {
            transform.position = position;
            Debug.Log(transform.position.ToString(""));
        }
    }

    private IEnumerable<Vector3> EnumeratePositions(Vector3 start, Vector3 end, int steps)
    {
        Vector3 distance = start - end;
        Vector3 stepValue = distance / steps;
        Vector3 currentStep = stepValue;

        for (int step = 1; step <= steps; step++)
        {
            currentStep = stepValue * step;
            yield return start - currentStep;
        }
    }
}
