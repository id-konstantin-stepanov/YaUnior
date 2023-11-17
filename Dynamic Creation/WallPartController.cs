using UnityEngine;

public class WallPartController : MonoBehaviour
{
    [SerializeField] private float _timeToDestroy = 3.0f;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.velocity = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f));
    }

    private void Update()
    {
        if (_rigidbody.velocity == Vector3.zero)
        {
            Destroy(_rigidbody);
            Destroy(gameObject, _timeToDestroy);
        }
        else if (transform.position.y <= -20)
        {
            Destroy(gameObject);
        }
    }
}
