using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AppleColision : MonoBehaviour, IColisionManzana
{
    private Manzana manzana = new Manzana();   
    private Podrida manzanaPodrida = new Podrida(new Manzana());
    private Dorada manzanaDorada = new Dorada(new Manzana());
    public Manzana Manzana
    {
        get => manzana;
        set => manzana = value;
    }

    public Podrida ManzanaPodrida
    {
        get => manzanaPodrida;
        set => manzanaPodrida = value;
    }

    public Dorada ManzanaDorada
    {
        get => manzanaDorada;
        set => manzanaDorada = value;
    }

    public void GanarPunto(Collision2D other)
    {

        if (other.gameObject.CompareTag("Apple") )
        {
            GameController.Instance.jugador.Puntuacion += Manzana.Puntaje();
           // Debug.Log("Gano punto!!");
            other.gameObject.transform.position = new Vector3(8, 8, 0);
            
            //Destroy(other.gameObject);
            //todo
            //Mandar a la posicion de respawn o destruir
        }else if (other.gameObject.CompareTag("Gold"))
        {
            GameController.Instance.jugador.Puntuacion += ManzanaDorada.Puntaje();
            //Destroy(other.gameObject);
            other.gameObject.transform.position = new Vector3(8, 8, 0);
        }else if (other.gameObject.CompareTag("Podrida") )
        {
            GameController.Instance.jugador.Puntuacion -= ManzanaPodrida.Puntaje();
           // Destroy(other.gameObject);
           other.gameObject.transform.position = new Vector3(8, 8, 0);
        }
        
  
        //TODO
        //Rescatar el valor de las manzanas decoradas
        //Falta una relacion que cubra ese aspecto
        
    }

   

    private void OnCollisionEnter2D(Collision2D other)
    {
        GanarPunto(other);
    }
}
