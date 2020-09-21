using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float fuerza;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
        
    /**
     * Este método se ejecuta una vez por frame
     */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 impulso = new Vector3(0, fuerza, 0);
            rb.AddForce(impulso);
        }
    }
}
