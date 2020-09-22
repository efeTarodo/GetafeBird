using System;
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
