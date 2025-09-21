using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    void IDamageable.TakeDamage(int damage)
    {
        Destroy(this.gameObject);
    }
}
