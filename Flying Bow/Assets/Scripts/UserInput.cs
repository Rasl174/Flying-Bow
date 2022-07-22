using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    [SerializeField] private Bow _bow;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _bow.Flying();
        }
    }

    public void AddNewBow(Bow bow)
    {
        _bow = bow;
    }
}
