using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bow : MonoBehaviour
{
    [SerializeField] private Vector3 _forceApplied;
    [SerializeField] private Vector3 _angularForceApplied;
    [SerializeField] private StringAnimation _stringAnimation;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private float _taimerWait;
    [SerializeField] private int _cicleCount;

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

    private IEnumerator Waiter()
    {
        yield return new WaitForSeconds(0.2f);
        _spawner.Spawn();
    }

    private IEnumerator StracherVelocity()
    {

        for (int i = 0; i < _cicleCount; i++)
        {
            _bowBody.velocity = _forceApplied * i;
            yield return new WaitForSeconds(_taimerWait);
        }
    }

    public void Flying()
    {
        _bowBody.angularVelocity = _angularForceApplied;
        _stringAnimation.Playing();
        StartCoroutine(StracherVelocity());
    }

    public void GetBody(Bow bow)
    {
        _bowBody = bow.GetComponent<Rigidbody>();
        StopCoroutine(StracherVelocity());
        Flying();
    }
}
