using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepAIBehaviour : MonoBehaviour {

    //start with enumerations (simple clear value cases)
	void Start ()
    {
        //vul selector node
        //List<INode> nodes = new List<INode>();
        //nodes.Add(new ConditionNode(IsHungry));
        //nodes.Add(new ActionNode(Eat));

        INode selectorNode =
            new SelectorNode(
                new SelectorNode(
                    new ConditionNode(IsHungry),
                    new ActionNode(Eat)),
                new SelectorNode(
                    new SelectorNode(
                        new ConditionNode(IsSleepy),
                        new ActionNode(Sleep))));

        //creeer een condition om de code van IsHungry in op te slaan
        //ConditionNode.Condition hungryCondition = IsHungry;

        //send the code from the method instead of the result of the method | don't use IsHungry(), but use IsHungry
        ConditionNode isHungryCondition = new ConditionNode(IsHungry);
        ConditionNode isSleepyCondition = new ConditionNode(IsSleepy);
	}
	
	void Update ()
    {
		
	}

    NodeResult Eat()
    {
        Debug.Log("Eat");
        return NodeResult.Succes;
    }

    NodeResult Sleep()
    {
        Debug.Log("Sleep");
        return NodeResult.Succes;
    }

    bool IsHungry()
    {
        return Random.Range(0, 1) > 0.3;
    }

    bool IsSleepy()
    {
        return Random.Range(0, 1) > 0.3;
    }
}
