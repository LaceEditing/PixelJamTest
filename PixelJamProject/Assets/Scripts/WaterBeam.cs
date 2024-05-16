using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterThrow : MonoBehaviour
{
    private Vector3 mousepos;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousepos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,rotZ);

    }
}
