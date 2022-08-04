using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickman : MonoBehaviour
{
    [SerializeField] private Animator _animation;
    [SerializeField] private Material _dieMaterial;
    [SerializeField] private SkinnedMeshRenderer _renderer;

    private Rigidbody _body;
    private bool _applicatedVelocity = false;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Arrow>(out Arrow arrow))
        {
            _animation.enabled = false;
            arrow.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            arrow.GetComponent<Rigidbody>().isKinematic = true;
            arrow.enabled = false;
            arrow.transform.SetParent(transform);
            _renderer.material = _dieMaterial;
        }
    }

    private void Update()
    {
        if(_animation.isActiveAndEnabled == false && _applicatedVelocity == false)
        {
            _applicatedVelocity = true;
            _body.velocity = Vector3.zero;
            _body.angularVelocity = Vector3.zero;
        }
    }
}
