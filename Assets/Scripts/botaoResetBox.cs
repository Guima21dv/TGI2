﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botaoResetBox : MonoBehaviour
{
    public Text aperteX;
    public bool colidPlayer;
    public GameObject bINT;
    public GameObject bFLOAT;
    public GameObject bBOOL;
    public GameObject bSTRING;
    public GameObject ConsoleReset;
    public AudioSource audioBt;

    void Start()
    {
        aperteX.enabled = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && colidPlayer)
        {
            RespawnBoxs();
            audioBt.Play();
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

    public void RespawnBoxs()
    {

        bINT.GetComponent<TargetJoint2D>().enabled = false;
        bFLOAT.GetComponent<TargetJoint2D>().enabled = false;
        bSTRING.GetComponent<TargetJoint2D>().enabled = false;
        bBOOL.GetComponent<TargetJoint2D>().enabled = false;
        bINT.transform.position = GameObject.FindGameObjectWithTag("respINT").transform.position;
        bFLOAT.transform.position = GameObject.FindGameObjectWithTag("respFLOAT").transform.position;
        bSTRING.transform.position = GameObject.FindGameObjectWithTag("respSTRING").transform.position;
        bBOOL.transform.position = GameObject.FindGameObjectWithTag("respBOOL").transform.position;
        ConsoleReset.SetActive(true);
        
    }


}
