using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bow : MonoBehaviour
{
    [SerializeField] private Vector3 _forceApplied;
    [SerializeField] private Vector3 _angularForceApplied;
    [SerializeField] private StringAnimation _stringAnimation;
    //[SerializeField] private float _arrowSpeed;
    [SerializeField] private Spawner _spawner;

    private Rigidbody _arrowBody;
    private Rigidbody _bowBody;

    private void Start()
    {
        _bowBody = GetComponent<Rigidbody>();
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.TryGetComponent<Arrow>(out Arrow arrow))
        {
            arrow.OffTrigger();
            StartCoroutine(Waiter());
        }
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

    //public void Shoot()
    //{
    //    Debug.Log(_arrowBody);

    //    _arrowBody.isKinematic = false;
    //    _arrowBody.velocity = -transform.right * _arrowSpeed;
    //}

    //public void GetArrowBody(Rigidbody arrowBody)
    //{
    //    _arrowBody = arrowBody;
    //    _arrowBody.isKinematic = true;
    //    Debug.Log(_arrowBody);
    //}

    private IEnumerator Waiter()
    {
        yield return new WaitForSeconds(0.2f);
        _spawner.Spawn();
    }
}
