using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickman : MonoBehaviour
{
    [SerializeField] private Animator _animation;
    [SerializeField] private Material _dieMaterial;
    [SerializeField] private SkinnedMeshRenderer _renderer;

    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent<Arrow>(out Arrow arrow))
        {
            _animation.enabled = false;
            _renderer.material = _dieMaterial;
            arrow.enabled = false;
            arrow.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            arrow.GetComponent<Rigidbody>().isKinematic = true;
            arrow.transform.SetParent(transform);
        }
    }
}
