using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{

    //InputAction grabAction;
    //CharacterController pizzaController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //grabAction = InputSystem.actions.FindAction("Interact");
        //CharacterController = GetComponent<CharacterController>();

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<IInteractableFood>(out IInteractableFood food))
        {
            food.GetPickedUp();
        }

    }

}
