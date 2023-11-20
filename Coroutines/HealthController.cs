using System.Collections;
using TMPro;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _smoothDecreaseDuration = 0.5f;
    [SerializeField] private float _damage = 1f;
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private Color _originalHealthColor;
    [SerializeField] private Color _damageHealthColor;
    [SerializeField] private Animator _heartAnimator;
    [SerializeField] private AnimationClip _heartPulseAnimation;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
        UpdateHealthText();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        _heartAnimator.Play(_heartPulseAnimation.name, 0, 0.0f);
        StartCoroutine(SmoothDecreseHealth(_damage));
    }

    private IEnumerator SmoothDecreseHealth(float damage)
    {
        _healthText.color = _damageHealthColor;
        float damagePerTick = damage / _smoothDecreaseDuration;
        float elapsedTime = 0f;

        while (elapsedTime < _smoothDecreaseDuration)
        {
            float currentDamage = damagePerTick * Time.deltaTime;
            _currentHealth -= currentDamage;
            elapsedTime += Time.deltaTime;

            UpdateHealthText();

            if (_currentHealth <= 0)
            {
                _currentHealth = 0;
                break;
            }
            yield return null;
        }
        _healthText.color = _originalHealthColor;
    }

    private void UpdateHealthText()
    {
        _healthText.text = _currentHealth.ToString("0");
    }
}
