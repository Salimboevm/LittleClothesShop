using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField]
    CharacterController characterController;
    public void Set()
    {
        gameObject.SetActive(true);
        characterController.SetCanMove(false);
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
        characterController.SetCanMove(true);
    }
}
