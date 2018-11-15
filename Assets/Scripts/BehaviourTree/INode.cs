using UnityEngine;
using System.Collections;

public interface INode
{
    //begin name of interface script with capital I | INode for example
    NodeResult Tick();
}
