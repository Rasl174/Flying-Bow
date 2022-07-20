using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private List<Bow> _bows;
    [SerializeField] private CameraMovement _camera;
    [SerializeField] private UserInput _userInput;

    private Quaternion _bowRotation;

    private void OnTriggerEnter(Collider bonus)
    {
        if(bonus.TryGetComponent<Bow>(out Bow bow))
        {
            Debug.Log("Enter");
            bow.gameObject.SetActive(false);
            _bows[0].gameObject.SetActive(true);
            _bows[0].gameObject.transform.position = bow.transform.position;
            _bowRotation = _bows[0].transform.rotation;
            _camera.AddNewTarget(_bows[0].transform);
            _userInput.AddNewBow(_bows[0]);
            _bows[0].GetBody(_bows[0]);
            foreach (var instantietedBow in _bows)
            {
                _bows.Remove(instantietedBow);
                break;
            }
        }
        gameObject.SetActive(false);
    }
}
