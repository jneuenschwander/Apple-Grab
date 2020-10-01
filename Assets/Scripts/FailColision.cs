using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailColision : MonoBehaviour , IFailColision
{
    public void PerderVida()
    {
        GameController.Instance.jugador.Vida--;
        Debug.Log("Haz perdido Vida");
    } 

    private void OnCollisionEnter2D(Collision2D other)
    {
        PerderVida();
        Destroy(other.gameObject);
    }
}
