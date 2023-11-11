using System.Collections.Generic;
using UnityEngine;

public class Iterator : MonoBehaviour
{
    private void Start()
    {
        foreach (int fibonacci in Fibonacci(5))
        {
            Debug.Log(fibonacci + " ");
        }
    }

    private IEnumerable<int> Fibonacci(int count)
    {
        for (int i = 0, previous = 1, current = 1; i < count; i++)
        {
            yield return previous;
            int next = previous + current;
            previous = current;
            current = next;
        }
    }
}
