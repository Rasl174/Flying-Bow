using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private BoxCollider _trigger;
    [SerializeField] private Bow _bow;
    [SerializeField] private float _arrowSpeed;

    private Rigidbody _body;

    private void Start()
    {
        _body = gameObject.GetComponent<Rigidbody>();
        _body.isKinematic = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        _body.isKinematic = false;
        _body.velocity = transform.up * _arrowSpeed;
    }

    public void OffTrigger()
    {
        _trigger.enabled = false;
    }
}
