using UnityEngine;
public class BarrierManager : MonoBehaviour, IDamageable
{
    [SerializeField] private int maxHealth;
    private float currentHealth;

    public HealthBarManager healthBarManager;

    void Start()
    {
        currentHealth = maxHealth;
    }
    void IDamageable.TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBarManager.UpdateHealth(currentHealth / maxHealth);
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
