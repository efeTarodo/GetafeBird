using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    [Tooltip("La velocidad de movimiento del obstáculo")]
    private float speed;
    [SerializeField]
    private GameObject cilindroSuperior;
    [SerializeField]
    private GameObject cilindroInferior;
    [Range(0,0.4f)]
    [SerializeField]
    private float umbralOffset;

    private GameManager manager;//Declaración de un COMPONENTE de tipo GameManager
    private void Start()
    {
        float offsetY = Random.Range(0, umbralOffset);
        cilindroSuperior.transform.Translate(Vector3.down * offsetY);
        cilindroInferior.transform.Translate(Vector3.up * offsetY);

        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (manager.IsPlaying() == true)
        {
            Vector3 movimiento = new Vector3(0, 0, speed * Time.deltaTime);
            transform.Translate(movimiento);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Limit")
        {
            Destroy(gameObject);
        }
    }
    
}
