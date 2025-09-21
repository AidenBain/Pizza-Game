using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;

    [SerializeField] private int speed;

    void Update()
    {
        transform.LookAt(player.transform);
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    
    
}
