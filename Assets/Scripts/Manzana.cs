using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manzana: DropItem
{
    private int _valor = 1;
    private float _velocidad = UnityEngine.Random.Range(0f, 5f);
    public override int Puntaje()
    {
        return 1;
    }
}
