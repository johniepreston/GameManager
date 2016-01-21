using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Location: MonoBehaviour, IPopulated, IContainer
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _description;
    [SerializeField]
    private int _capacity;
    [SerializeField]
    private List<Character> _characters = new List<Character>();
    [SerializeField]
    public List<IStackable> _items = new List<IStackable>();
    public List<Character> Characters
    {
        get
        {
            return _characters;
        }

        set
        {
            _characters = value;
        }
    }
    public List<IStackable> Items
    {
        get
        {
            return _items;
        }

        set
        {
            _items = value;
        }
    }
}