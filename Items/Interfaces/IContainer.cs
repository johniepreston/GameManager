using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IContainer
{
    List<IStackable> Items { get; set; }
}
