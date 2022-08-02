using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _food;

    private Vector3 _spawnPosition;

    private void Start()
    {
        _spawnPosition.z = transform.position.z + 1;
    }

    public void Spawn()
    {
        Instantiate(_food, _spawnPosition, Quaternion.identity);
    }
}
