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
    GameManager manager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        manager = GameObject.Find("GameManager").GetComponent <GameManager>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 impulso = new Vector3(0, fuerza, 0);
            rb.AddForce(impulso);
            GetComponents<AudioSource>()[0].Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        manager.StopGame();
        Instantiate(prefabSangre, transform);
        gameObject.GetComponents<AudioSource>()[1].Play();
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
