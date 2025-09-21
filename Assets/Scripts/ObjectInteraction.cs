using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectInteraction : MonoBehaviour
{

    InputAction grabAction;
    bool grabActionisPressed = false;
    IInteractableFood? carriedFood = null;
    GameObject playerObj;
    [SerializeField]GameObject pizzaPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        grabAction = InputSystem.actions.FindAction("Interact");
        grabAction.Enable();
        //InputSystem.actions.FindAction(;"Interact");
        playerObj = GameObject.Find("Player");

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
        if (other.TryGetComponent<IInteractableFood>(out IInteractableFood food))
        {
            if (grabAction.IsPressed() && !grabActionisPressed && carriedFood == null)
            {
                food.GetPickedUp();
                carriedFood = food;
                grabActionisPressed = true;
            }

        }

        if (grabAction.IsPressed() && !grabActionisPressed && carriedFood != null)
        {
            carriedFood.GetPutDown();
            carriedFood = null;
            grabActionisPressed = true;
        }

        if(other.name == "Oven")
        {
            if (grabAction.IsPressed() && !grabActionisPressed)
            {
                GameObject pizza = Instantiate(pizzaPrefab, playerObj.transform.position, Quaternion.identity);
                pizza.TryGetComponent<IInteractableFood>(out IInteractableFood interactablePizza);
                interactablePizza.GetPickedUp();
                carriedFood = interactablePizza;
                grabActionisPressed = true;
            }
            
        }

    }



}
