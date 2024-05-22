using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int health, maxHealth = 10;
    [SerializeField] private float damageDelay = 1.0f;
    float m_DamageCooldown = 0;


    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        if (m_DamageCooldown > 0)
            m_DamageCooldown -= Time.deltaTime;
    }


    public void TakeDamageP(int amount)
    {
        if (m_DamageCooldown > 0)
            return;
        m_DamageCooldown = damageDelay;
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyController e = collision.gameObject.GetComponent<EnemyController>();
        if (e)
        {
            TakeDamageP(e.damage); // Subtract damage when colliding with an enemy 
        }
    }
}
