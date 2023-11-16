using UnityEngine;

public class GameObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Material _material;
    [SerializeField] private Quaternion _rotation = Quaternion.Euler(45, 0, 0);
    [SerializeField] private Vector3 _position = new Vector3(2, 0, 0);

    private void Start()
    {
        Instantiator(_cubePrefab);
        Creator(_material, _rotation, _position);
    }

    private void Instantiator(GameObject prefab)
    {
        Instantiate(prefab);
    }

    private void Creator(Material material, Quaternion rotation, Vector3 position)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material = material;
        cube.transform.rotation = rotation;
        cube.transform.position = position;
    }
}
