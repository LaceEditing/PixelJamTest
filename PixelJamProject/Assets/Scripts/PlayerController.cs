using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    public float damageDelay = 1.0f;
    float m_DamageCooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
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
