using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepAIBehaviour : MonoBehaviour {

    //start with enumerations (simple clear value cases)
	void Start ()
    {
        //creeer een condition om de code van IsHungry in op te slaan
        ConditionNode.Condition hungryCondition = IsHungry;

        //send the code from the method instead of the result of the method | don't use IsHungry(), but use IsHungry
        ConditionNode isHungryCondition = new ConditionNode(hungryCondition);
        ConditionNode isSleepyCondition = new ConditionNode(IsSleepy);
	}
	
	void Update ()
    {
		
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
