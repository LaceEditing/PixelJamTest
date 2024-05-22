using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField] private int health, maxHealth = 100;
    public int damage = 1;


    void Start()
    {
        health = maxHealth;
    }


    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    void OnParticleCollision(GameObject other)
    {
        TakeDamage(1);
    }
}
