using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public delegate void StateAction(StateMachine sm);

    private Dictionary<string, StateAction> states = new Dictionary<string, StateAction>();
    private StateAction activeStateAction = null;

    public int AddState(string stateName, StateAction stateAction)
    {
        if (!states.ContainsKey(stateName))
        {
            states.Add(stateName, stateAction);
            return 0;
        }
        else
            return -1;
    }

    public void Reset()
    {
        activeStateAction = null;
    }

    public int SetActiveState(string stateName)
    {
        StateAction stateAction;
        if (states.TryGetValue(stateName, out stateAction))
        {
            activeStateAction = stateAction;
            return 0;
        }
        else
            return -1;
    }

    public int Run()
    {
        if (activeStateAction == null)
        {
            return -1;
        }
        activeStateAction(this);
        return 0;
    }
}
