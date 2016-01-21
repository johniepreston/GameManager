using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

interface IPhysiology
{
    /// <summary>
    /// Возраст
    /// </summary>
    int Age { get; set; }
    /// <summary>
    /// Вес
    /// </summary>
    float Weight { get; set; }
    /// <summary>
    /// Рост
    /// </summary>
    float Height { get; set; }
    /// <summary>
    /// Размер груди
    /// </summary>
    int BreastSize { get; set; }
    /// <summary>
    /// Цвет волос
    /// </summary>
    Color HairColor { get; set; }
    /// <summary>
    /// Цвет глаз
    /// </summary>
    Color EyesColor { get; set; }
}