﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public void chamaCena()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Inicio");
    }
    public void sairJogo()
    {
        Application.Quit();
    }
}