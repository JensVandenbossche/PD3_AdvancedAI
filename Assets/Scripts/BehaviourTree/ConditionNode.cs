using UnityEngine;
using System.Collections;

//is een INode | ConditionNode : INode
public class ConditionNode : INode
{
    //delegate is een type dat je definieert om een methode in op te slaan
    public delegate bool Condition();
    
    private readonly Condition _condition;

    public ConditionNode (Condition condition)
    {
        //ontvang de code en stop het in de condition
        _condition = condition;
    }

    public NodeResult Tick()
    {
        //gebruik de code die is opgeslaan in de condition variabele
        if (_condition())
            return NodeResult.Succes;
        else
            return NodeResult.Failure;
    }
}
