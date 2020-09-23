using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Range(-1,-0.1f)]
    public float minRange;
    [Range(0.1f, 1)]
    public float maxRange;
    public float tiempoEntreSpawns;
    public GameObject obstaculo;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0, tiempoEntreSpawns);
    }

    void SpawnObstacle()
    {
        float offset = Random.Range(minRange, maxRange);//Hardcode
        UnityEngine.Vector3 obstaclePosition = new UnityEngine.Vector3(
            transform.position.x,
            transform.position.y + offset,
            transform.position.z);
        Instantiate(obstaculo, obstaclePosition, transform.rotation);
    }
    
}
