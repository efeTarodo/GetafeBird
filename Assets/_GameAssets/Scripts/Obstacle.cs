using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        Vector3 movimiento = new Vector3(0, 0, speed * Time.deltaTime);
        transform.Translate(movimiento);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Limit")
        {
            Destroy(gameObject);
        }
    }
}
