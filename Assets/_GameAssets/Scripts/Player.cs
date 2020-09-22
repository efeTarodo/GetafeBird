using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabSangre;
    public float fuerza;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
       
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 impulso = new Vector3(0, fuerza, 0);
            rb.AddForce(impulso);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(prefabSangre, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().IncrementarPuntuacion();
    }
}
