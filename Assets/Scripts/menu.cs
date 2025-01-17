﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class menu : MonoBehaviour
{

    public GameObject historia;
    public GameObject btHistoria;
    public GameObject NPCbom;
    public GameObject NPCruim;
    public GameObject painelMenu;
    public GameObject luz;

    public void chamaHistoria()
    {
        StartCoroutine(delayHistoria());
    }

    IEnumerator delayHistoria()
    {
        yield return new WaitForSeconds(0.3f);
        painelMenu.SetActive(false);
        luz.SetActive(false);
        NPCbom.SetActive(false);
        NPCruim.SetActive(true);
        historia.SetActive(true);
        btHistoria.SetActive(true);
    }

    public void chamaCena()
    {
        StartCoroutine(delayCena());
    }

    IEnumerator delayCena()
    {
        yield return new WaitForSeconds(0.3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Cena 2 Jogo");
    }


    public void sairJogo()
    {
        StartCoroutine(delaySair());
    }

    IEnumerator delaySair()
    {
        yield return new WaitForSeconds(0.2f);
        Application.Quit();
    }
}
