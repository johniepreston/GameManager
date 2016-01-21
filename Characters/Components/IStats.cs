using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IStats
{
    /// <summary>
    /// Сила
    /// </summary>
    int Strenght { get; set; }
    /// <summary>
    /// Ловкость
    /// </summary>
    int Agility { get; set; }
    /// <summary>
    /// Харизма
    /// </summary>
    int Charisma { get; set; }
    /// <summary>
    /// Удача
    /// </summary>
    int Luck { get; set; }
}
