using UnityEngine;
using System.Collections;

public class ActionNode : INode
{
    public delegate NodeResult Action();
    private readonly Action _action;

    public ActionNode(Action action)
    {
        _action = action;
    }

    public NodeResult Tick()
    {
        return _action();
    }
}
