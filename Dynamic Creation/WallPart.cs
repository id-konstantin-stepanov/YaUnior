using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class WallPart : MonoBehaviour
{
    [SerializeField] private float _timeToDestroy = 3.0f;
    [SerializeField] private float _randomCoefficient = 0.1f;
    [SerializeField] private float _heightLimit = -20;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.velocity = new Vector3(Random.Range(-_randomCoefficient, _randomCoefficient),
                                          Random.Range(-_randomCoefficient, _randomCoefficient),
                                          Random.Range(-_randomCoefficient, _randomCoefficient));
    }

    private void Update()
    {
        if (_rigidbody.velocity == Vector3.zero)
        {
            Destroy(_rigidbody);
            Destroy(gameObject, _timeToDestroy);
        }
        else if (transform.position.y <= _heightLimit)
        {
            Destroy(gameObject);
        }
    }
}
