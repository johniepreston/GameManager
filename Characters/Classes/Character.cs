using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Character : MonoBehaviour, ICharacter, IHurtable, IStats
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private int _level;
    [SerializeField]
    private int _health;
    
    public string Name { get { return _name; } set { _name = value; } }
    public int Level { get { return _level; } set { _level = value; } }
    public int Health { get { return _health; } set { _health = value; } }
    public int Strenght { get; set; }
    public int Agility { get; set; }
    public int Charisma { get; set; }
    public int Luck { get; set; }
    public void Damage(int amount)
    {
        Health -= amount;
    }
    public void Heal(int amount)
    {
        Health += amount;
    }
}