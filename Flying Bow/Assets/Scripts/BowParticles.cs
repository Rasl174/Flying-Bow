using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem _boom;

    private bool _instantiated = false;

    private void Update()
    {
        if(gameObject.activeSelf == true && _instantiated == false)
        {
            _instantiated = true;
            Instantiate(_boom, transform.position, Quaternion.identity);
        }
    }
}
