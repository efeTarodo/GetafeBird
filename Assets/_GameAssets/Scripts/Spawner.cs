using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float tiempoEntreSpawns;
    public GameObject obstaculo;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0, tiempoEntreSpawns);
    }

    void SpawnObstacle()
    {
        Instantiate(obstaculo, transform.position, transform.rotation);
    }
    
}
