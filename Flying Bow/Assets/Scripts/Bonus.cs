using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private Bow _bow;
    [SerializeField] private CameraMovement _camera;
    [SerializeField] private UserInput _userInput;

    private void OnTriggerEnter(Collider bonus)
    {
        if(bonus.TryGetComponent<Bow>(out Bow bow))
        {
            bow.gameObject.SetActive(false);
            _bow.gameObject.SetActive(true);
            _bow.gameObject.transform.position = bow.transform.position;
            _camera.AddNewTarget(_bow.transform);
            _userInput.AddNewBow(_bow);
            _bow.GetBody(_bow);
            gameObject.SetActive(false);
        }
    }
}
