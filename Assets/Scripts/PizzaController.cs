using UnityEngine;

public class PizzaController : MonoBehaviour, IInteractableFood
{

    GameObject playerObj;
    GameObject pizzaObj;
    bool isGettingCarried = false;
    [SerializeField] Vector3 holdingPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObj = GameObject.Find("Player");
        pizzaObj = GameObject.Find("Pizza");
    }

    // Update is called once per frame
    void Update()
    {
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
        pizzaObj.GetComponent<Rigidbody>().AddForce(Vector3.left * 500);
    }

    /*void OnCollisionEnter(Collision collision)
    {
        print("hi");
    }*/

}
