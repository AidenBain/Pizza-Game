using UnityEngine;
public class BarrierManager : MonoBehaviour, IDamageable
{
    [SerializeField] private int maxHealth;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }
    void IDamageable.TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
