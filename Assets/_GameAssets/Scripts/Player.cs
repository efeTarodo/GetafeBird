using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            GetComponent<AudioSource>().Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(prefabSangre, transform);
        Invoke("CargarEscena", 3);
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().IncrementarPuntuacion();
        other.gameObject.GetComponent<AudioSource>().Play();
    }

    private void CargarEscena()
    {
        SceneManager.LoadScene("MainScene");
    }
}
