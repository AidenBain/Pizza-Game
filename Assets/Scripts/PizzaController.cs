using UnityEngine;

public class PizzaController : MonoBehaviour, IInteractableFood
{
    
    GameObject playerObj;
    Transform pizzaTransform;
    bool isGettingCarried = false;
    [SerializeField] Vector3 holdingPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObj = GameObject.Find("Player");
        pizzaTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGettingCarried)
        {
            pizzaTransform.position = playerObj.GetComponent<Transform>().position + holdingPosition;
        }
    }


    void IInteractableFood.GetPickedUp()
    {
        isGettingCarried = true;
    }

    /*void OnTriggerEnter(Collider other)
    {
        GetPickedUp();

    }*/
}
