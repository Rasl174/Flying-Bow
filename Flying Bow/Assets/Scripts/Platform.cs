using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent<Arrow>(out Arrow arrow))
        {
            arrow.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}
