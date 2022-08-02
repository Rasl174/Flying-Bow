using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : MonoBehaviour
{
    [SerializeField] private Vector3 _velocityForce;

    private Rigidbody _body;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
        _body.Sleep();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Arrow>(out Arrow arrow))
        {
            _body.WakeUp();
            _body.velocity = _velocityForce;
        }
    }
}
