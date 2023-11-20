using UnityEngine;

public class ExtendedSpawner : MonoBehaviour
{
    [SerializeField] private Mesh _mesh;
    [SerializeField] private Material _material;
    [SerializeField] private Quaternion _rotation = Quaternion.identity;
    [SerializeField] private Vector3 _position = Vector3.zero;

    private void Start()
    {
        CreateManually();
    }

    private void CreateManually()
    {
        GameObject cube = new GameObject("Cube");
        MeshFilter filter = cube.AddComponent<MeshFilter>();
        filter.mesh = _mesh;
        cube.AddComponent<MeshRenderer>();
        cube.AddComponent<BoxCollider>();
        cube.GetComponent<Renderer>().material = _material;
        cube.transform.rotation = _rotation;
        cube.transform.position = _position;
        cube.AddComponent<Rigidbody>();
    }
}
