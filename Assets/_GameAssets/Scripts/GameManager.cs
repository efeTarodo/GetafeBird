﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int score = 0;
    private bool playing = false;

    public bool IsPlaying()
    {
        return playing;
    }

    public void StopGame()
    {
        playing = false;
    }

    private void Awake()
    {
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("FIN DEL JUEGO");
            Application.Quit();
        }

        if (playing == false) {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 1;
                if (GameObject.Find("TextPulsa") != null)
                {
                    GameObject.Find("TextPulsa").SetActive(false);
                }
                playing = true;
            }
        }
    }

    public void IncrementarPuntuacion()
    {
        score++;//score = score + 1;
        GameObject.Find("TextScore").GetComponent<Text>().text = ""+score;
    }

    public void IniciarPartida()
    {
        score = 0;
        playing = true;
    }

    public void TerminarPartida()
    {
        playing = false;
    }
    
}
