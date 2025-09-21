using System.Data;
using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;

public interface IDamageable
{
    void TakeDamage(int damage);
}

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float attackDelay;
    [SerializeField] private int damage;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out IDamageable damageable))
        {
            StartCoroutine(attackCouroutine(damageable));
        }
    }

    void OerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out IDamageable damageable))
        {
            StopCoroutine(attackCouroutine(damageable));
        }
    }

    IEnumerator attackCouroutine(IDamageable damageable)
    {
        while (true)
        {
            yield return new WaitForSeconds(attackDelay);
            damageable.TakeDamage(damage);
        }
    }

}
