using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IPersonality
{
    /// <summary>
    /// Характеризует персонажа с позиции добро/зло
    /// </summary>
    int Attitude { get; set; }
    /// <summary>
    /// Характеризует, насколько персонаж воспринимает чувства других
    /// </summary>
    float Sensitivity { get; set; }
    /// <summary>
    /// Характеризует, насколько сильно можно влиять на персонаж
    /// </summary>
    float Volition { get; set; }
}

