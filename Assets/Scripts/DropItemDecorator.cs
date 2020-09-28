using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DropItemDecorator: DropItem
{
    protected DropItem _dropItem;

    public DropItemDecorator(DropItem dropItem)
    {
        this._dropItem = dropItem;
    }

    public void SetDropItem()
    {
        this._dropItem = _dropItem;
    }
    public override int Puntaje()
    {
        if (this._dropItem != null)
        {
            return this._dropItem.Puntaje();
        }
        else
        {
            return 0;
        }
    }

}
