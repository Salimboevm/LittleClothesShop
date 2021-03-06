using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterInteract : MonoBehaviour
{
    CharacterController characterController;
    Character character;
    Rigidbody2D rb2D;
    [SerializeField]
    float offset = 2f;
    [SerializeField]
    float sizeOfInteractables = 1.2f;
    [SerializeField]
    private GameObject inventoryUI;
    private bool canInteract;
    public bool CanInteract { get => canInteract; private set => canInteract = value; }


    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        rb2D = GetComponent<Rigidbody2D>();
        character = GetComponent<Character>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract)
            {
                Interact();
            }
            else
                return;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }
    
    void Interact()
    {
        Vector2 pos = rb2D.position + characterController.Motion * offset;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(pos, sizeOfInteractables);

        foreach (Collider2D collider in colliders)
        {
            Interactable interact = collider.GetComponent<Interactable>();
            if(interact != null)
            {
                interact.Interact(character);
                break;
            }
        }
    }
    
    public bool SetCanInteract(bool v)
    {
        return canInteract = v;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(gameObject.transform.position, sizeOfInteractables);
    }
}
