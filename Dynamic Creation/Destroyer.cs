using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private Rigidbody _sphere;
    [SerializeField] private GameObject _wallPrefab;

    private void Start()
    {
        _sphere.AddForce(new Vector3(0, 1.5f, 3.0f) * 200);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Instantiate(_wallPrefab, _wallPrefab.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
