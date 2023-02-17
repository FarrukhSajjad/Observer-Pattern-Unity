using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    public List<EventListener> eventListeners = new List<EventListener>();

    public int numOfListeners;

    //Event Raised on Game Events Parameters
    public void RaiseEvent(GameEventParameters parameters)
    {
        numOfListeners = eventListeners.Count;
        for (var i = 0; i < numOfListeners; i++)
        {
            eventListeners[i].OnEventRaised(parameters);
        }
    }

    public void RegisterEvent(EventListener listener)
    {
        if (!eventListeners.Contains(listener))
        {
            eventListeners.Add(listener);
        }
    }

    public void DeRegisterEvent(EventListener listener)
    {
        if (!eventListeners.Contains(listener)) return;
        eventListeners.Remove(listener);
        numOfListeners--;
    }
}