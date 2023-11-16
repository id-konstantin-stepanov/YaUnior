using UnityEngine;

public class ExtendedGameObjectSpawner : MonoBehaviour
{
    [SerializeField] private Mesh _mesh;
    [SerializeField] private Material _material;
    [SerializeField] private Quaternion _rotation = Quaternion.identity;
    [SerializeField] private Vector3 _position = Vector3.zero;

    private void Start()
    {
        Creator(_mesh, _material, _rotation, _position);
    }

    private void Creator(Mesh mesh, Material material, Quaternion rotation, Vector3 position)
    {
        GameObject cube = new GameObject("Cube");
        MeshFilter filter = cube.AddComponent<MeshFilter>();
        filter.mesh = mesh;
        cube.AddComponent<MeshRenderer>();
        cube.AddComponent<BoxCollider>();
        cube.GetComponent<Renderer>().material = material;
        cube.transform.rotation = rotation;
        cube.transform.position = position;

        cube.AddComponent<Rigidbody>();
    }
}
