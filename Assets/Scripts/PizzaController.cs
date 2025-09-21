using UnityEngine;
using UnityEngine.InputSystem;

public class PizzaController : MonoBehaviour, IInteractableFood
{
    InputAction moveAction;
    Vector3 directionThrowable;
    GameObject playerObj;
    GameObject pizzaObj;
    bool isGettingCarried = false;
    [SerializeField] Vector3 holdingPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObj = GameObject.Find("Player");
        moveAction = InputSystem.actions.FindAction("Move");
        pizzaObj = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        directionThrowable = new Vector3(moveInput.x, 0, moveInput.y);

        if (isGettingCarried)
        {
            pizzaObj.transform.position = playerObj.GetComponent<Transform>().position + holdingPosition;
        }
    }


    void IInteractableFood.GetPickedUp()
    {
        isGettingCarried = true;
    }

    void IInteractableFood.GetPutDown()
    {
        isGettingCarried = false;
        pizzaObj.GetComponent<Rigidbody>().AddForce(directionThrowable * 500);
    }

    /*void OnCollisionEnter(Collision collision)
    {
        print("hi");
    }*/

}
