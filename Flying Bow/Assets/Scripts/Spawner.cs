using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _arrow;

    private void Start()
    {
        Instantiate(_arrow, transform);
    }

    public void Spawn()
    {
        Instantiate(_arrow, transform);
    }
}
