using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private BoxCollider _trigger;
    [SerializeField] private BoxCollider _tip;
    [SerializeField] private Bow _bow;
    [SerializeField] private float _arrowSpeed;

    private Rigidbody _body;

    private void Start()
    {
        _tip.enabled = false;
        _body = gameObject.GetComponent<Rigidbody>();
        _body.isKinematic = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
            _tip.enabled = true;
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
