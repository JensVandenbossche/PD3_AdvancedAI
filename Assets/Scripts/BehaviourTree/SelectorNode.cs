using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelectorNode : INode
{
    //List<ActionNode> _actionNodes = new List<ActionNode>();
    //List<ConditionNode> _conditionNodes = new List<ConditionNode>();
    //List<SelectorNode> _selectorNodes = new List<SelectorNode>();

    INode[] _nodes;

    public SelectorNode(params INode[] nodes)
    {
        _nodes = nodes;
    }

    //selector kijkt of 1 van deze methodes success returned
    public NodeResult Tick()
    {
        foreach(INode node in _nodes)
        {
            NodeResult result = node.Tick();
            if (result == NodeResult.Failure)
                continue;

            return result;
        }

        return NodeResult.Failure;
    }
}
