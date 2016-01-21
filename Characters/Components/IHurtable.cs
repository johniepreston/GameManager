using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IHurtable
{
    int Health { get; set; }
    void Damage(int amount);
    void Heal(int amoun);
}