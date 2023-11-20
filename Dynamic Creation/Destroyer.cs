using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private Rigidbody _bulletRigidbody;
    [SerializeField] private Transform _wallPrefab;
    [SerializeField] private Vector3 _forceVector = new Vector3(0, 1.5f, 3.0f);
    [SerializeField] private float _force = 200;

    private void Start()
    {
        _bulletRigidbody.AddForce(_forceVector * _force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Wall _))
        {
            Instantiate(_wallPrefab, _wallPrefab.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
