using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBuff : MonoBehaviour
{
    public float buff = (float) .10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        PlayerMovement p = collision.gameObject.GetComponent<PlayerMovement>();
        if (p)
        {
            p.moveSpeed += buff; 
            Destroy(gameObject);
        }
    }
}
