using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private float _arrowSpeed;
    [SerializeField] private BoxCollider _trigger;

    private Rigidbody _arrowBody;

    private void Start()
    {
        _arrowBody = GetComponent<Rigidbody>();
        _arrowBody.isKinematic = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        _arrowBody.isKinematic = false;
        _arrowBody.velocity = transform.up * _arrowSpeed;
    }

    public void ColliderOff()
    {
        _trigger.enabled = false;
    }
}
