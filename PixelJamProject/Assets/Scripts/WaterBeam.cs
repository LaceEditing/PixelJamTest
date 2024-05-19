using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterThrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<EnemyController>(out EnemyController enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }
    }
}
