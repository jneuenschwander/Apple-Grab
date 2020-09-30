﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EmpezarJuego() // se coloco en el boton de empezar video juego
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CerrarJuego() // se coloco en el boton de cerrar jeugo
    {
        Application.Quit();
        Debug.Log("Salir");
    }
}
