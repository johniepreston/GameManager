using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum ItemType
{
    Equipiment,
    Consumables,
    Misc
}

public class Item : IStackable
{
    private int _id;
    private string _name;
    private float _cost;
    private int _count;
    private ItemType _itemType;
}
