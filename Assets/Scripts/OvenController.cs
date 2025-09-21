using UnityEngine;

public class OvenController : MonoBehaviour
{

    bool hasPizza = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IInteractableFood>(out IInteractableFood food))
        {
            Destroy(other.gameObject);
            hasPizza = true;

        }
    }
}
