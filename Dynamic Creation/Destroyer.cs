using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private Rigidbody _sphere;
    [SerializeField] private Wall _wallPrefab;

    private void Start()
    {
        _sphere.AddForce(new Vector3(0, 1.5f, 3.0f) * 200);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Wall _))
        {
            Instantiate(_wallPrefab, _wallPrefab.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
