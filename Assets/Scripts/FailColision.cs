using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailColision : MonoBehaviour , IFailColision
{
    public void PerderVida()
    {
        GameController.Instance.jugador.Vida--;
    } 

    private void OnCollisionEnter(Collision other)
    {
        PerderVida();
    }
}
