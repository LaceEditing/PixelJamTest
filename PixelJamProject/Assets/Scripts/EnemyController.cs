using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public int health;
    public int maxHealth = 100;
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
