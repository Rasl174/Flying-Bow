using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsAnimation : MonoBehaviour
{
    [SerializeField] private GameObject _points;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Arrow>(out Arrow arrow))
        {
            _points.gameObject.SetActive(true);
        }
    }
}
