using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleColision : MonoBehaviour, IColisionManzana
{
    public void GanarPunto()
    {
        GameController.Instance.jugador.Puntuacion++;// sube la puntuacion en 1
        //TODO
        //Rescatar el valor de las manzanas decoradas
        //Falta una relacion que cubra ese aspecto
        
    }

    private void OnCollisionEnter(Collision other)
    {
        GanarPunto();
    }
}
