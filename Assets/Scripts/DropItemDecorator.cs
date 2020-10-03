using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DropItemDecorator: DropItem
{
    protected DropItem dropItem;

    public DropItemDecorator(DropItem dropItem)
    {
        this.dropItem = dropItem;
    }

    public DropItem DropItem
    {
        get => dropItem;
        set => dropItem = value;
    }

    public override int Puntaje()
    {
        if (this.dropItem != null)
        {
            return this.dropItem.Puntaje();
        }
        else
        {
            return 0;
        }
    }

}
