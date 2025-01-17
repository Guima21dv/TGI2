﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PainelM3 : MonoBehaviour
{
    public GameObject painelM3;
    public bool colidPlayer;
    public bool painelM3Ativo;
    public string texto;
    public TMP_InputField textoinput;
    public GameObject Smute;
    public GameObject CanvasPauseRestart;
    public GameObject Player;

    public AudioSource xClique;
    public Text aperteX;
    public GameObject ConsoleERRO;


    void Start()
    {
        aperteX.enabled = false;

    }


    public void Update()
    {
        texto = textoinput.text;

        if (Input.GetKeyDown(KeyCode.X) && colidPlayer && !painelM3Ativo)
        {
            ativarP3();
            aperteX.enabled = false;

        }


        if (Input.GetKeyDown(KeyCode.KeypadEnter) && painelM3Ativo || Input.GetKeyDown(KeyCode.Return) && painelM3Ativo)
        {
            ativarPlataforma();
            P3Continuar();

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


    public void ativarP3()
    {
        painelM3.SetActive(true);
        painelM3Ativo = true;
        Smute.GetComponent<mute>().MonitorAtivado = true;
        CanvasPauseRestart.GetComponent<Pause>().MonitorAtivado = true;
        CanvasPauseRestart.GetComponent<Restart>().MonitorAtivado = true;
        Player.GetComponent<Player>().MonitorAtivado = true;
        textoinput.Select();
        textoinput.ActivateInputField();
        xClique.Play();
    }
    public void P3Continuar()
    {
        painelM3.SetActive(false);
        painelM3Ativo = false;
        Smute.GetComponent<mute>().MonitorAtivado = false;
        CanvasPauseRestart.GetComponent<Pause>().MonitorAtivado = false;
        CanvasPauseRestart.GetComponent<Restart>().MonitorAtivado = false;
        Player.GetComponent<Player>().MonitorAtivado = false;
        xClique.Play();
    }


    public void ativarPlataforma()
    {
        if (texto == "True")
        {
            AtivarMoveP.ativar = true;

        }
        else if (texto == "False")
        {
            AtivarMoveP.ativar = false;

        }
        else
        {
            AtivarMoveP.ativar = false;
            ConsoleERRO.GetComponent<TextMeshProUGUI>().text = "ERRO! O valor não existe no contexto atual";
            ConsoleERRO.SetActive(true);
            ConsoleERRO.GetComponent<AudioSource>().Play();
        }
    }


}