﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class btM7funcao : MonoBehaviour
{

    public Text aperteX;
    public bool colidPlayer;
    public int cds;
    public GameObject Player;
    public GameObject ConsoleErro;
    public GameObject Key;
    public GameObject consoleCD1;
    public GameObject consoleCD2;

    void Start()
    {
        aperteX.enabled = false;
    }

   
    void Update()
    {

        cds = Player.GetComponent<Player>().cd;
        if (Input.GetKeyDown(KeyCode.X) && colidPlayer)
        {
            gerarChave();
            aperteX.enabled = false;

        }

    }

    public void OnTriggerEnter2D(Collider2D collision2d)
    {
        if (collision2d.gameObject.CompareTag("Player"))
        {
            colidPlayer = true;
            aperteX.enabled = true;

        }

    }

    public void OnTriggerExit2D(Collider2D collision2d)
    {
        if (collision2d.gameObject.CompareTag("Player"))
        {
            colidPlayer = false;
            aperteX.enabled = false;
        }

    }

    public void gerarChave()
    {
        if(cds == 2)
        {
            Key.SetActive(true);
            Player.GetComponent<Player>().cd = 0;
            consoleCD1.SetActive(false);
            consoleCD2.SetActive(false);

        }
        else
        {
            ConsoleErro.GetComponent<TextMeshProUGUI>().text = "Esta função precisa de 2 valores de entrada";
            ConsoleErro.SetActive(true);
        }
    }


}