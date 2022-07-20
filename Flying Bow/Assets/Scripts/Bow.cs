using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bow : MonoBehaviour
{
    [SerializeField] private Vector3 _forceApplied;
    [SerializeField] private Vector3 _angularForceApplied;
    [SerializeField] private StringAnimation _stringAnimation;

    private Rigidbody _bowBody;

    private void Start()
    {
        _bowBody = GetComponent<Rigidbody>();
    }

    public void Flying()
    {
        _bowBody.velocity = _forceApplied;
        _bowBody.angularVelocity = _angularForceApplied;
        _stringAnimation.Playing();
    }

    public void GetBody(Bow bow)
    {
        _bowBody = bow.GetComponent<Rigidbody>();
    }
}
