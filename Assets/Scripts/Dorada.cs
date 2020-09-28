using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dorada : DropItemDecorator
{
    private Manzana _manzana;
    public Dorada(DropItem dropItem) : base(dropItem)// !!!!verificar si funciona
    {
        this._manzana = (Manzana) dropItem;
    }

    public override int Puntaje()
    {
        return base.Puntaje() - 2;
    }
}
