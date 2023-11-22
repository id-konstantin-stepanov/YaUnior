using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100f;

    private float _currentHealth;

    public float MaxHealth => _maxHealth;

    public event Action<float> Changed;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth = Mathf.Clamp(_currentHealth - damage, 0, _maxHealth);
        Changed?.Invoke(_currentHealth);
    }
}
