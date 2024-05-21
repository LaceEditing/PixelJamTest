using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterThrow : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<EnemyController>(out EnemyController enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }
    }
}
