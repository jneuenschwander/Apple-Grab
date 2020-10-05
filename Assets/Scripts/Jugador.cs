using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador
{
    private int vida = 10;
    private int puntuacion = 0;

    public int Vida
    {
        get => vida;
        set => vida = value;
    }

    public int Puntuacion
    {
        get => puntuacion;
        set => puntuacion = value;
    }
}
