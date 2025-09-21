using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectInteraction : MonoBehaviour
{

    InputAction grabAction;
    bool grabActionisPressed = false;
    IInteractableFood? carriedFood = null;
    //CharacterController pizzaController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        grabAction = InputSystem.actions.FindAction("Interact");
        grabAction.Enable();
        //InputSystem.actions.FindAction(;"Interact");
        //CharacterController = GetComponent<CharacterController>();

    }

    void Update()
    {

        if(!grabAction.IsPressed() && grabActionisPressed)
        {
            grabActionisPressed = false;
        }

    }

    void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent<IInteractableFood>(out IInteractableFood food))
        {
            if(grabAction.IsPressed() && !grabActionisPressed)
            {
                food.GetPickedUp();
                carriedFood = food;
                grabActionisPressed = true;
            }
            
        }

        if(other.name == "Oven")
        {
            if(grabAction.IsPressed())
            {
                if(carriedFood != null)
                {
                    carriedFood.GetPutDown();
                }
                carriedFood = null;
            }
            
        }

    }



}
