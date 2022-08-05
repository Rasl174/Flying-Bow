using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] private Vector3 _velocityForce;

    private Rigidbody _body;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
        _body.Sleep();
        _body.isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Arrow>(out Arrow arrow))
        {
            _body.WakeUp();
            _body.isKinematic = false;
            _body.velocity = _velocityForce;
        }
    }
}
