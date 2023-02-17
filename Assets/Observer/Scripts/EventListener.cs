using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public List<GameEvent> events = new List<GameEvent>();

    //Action response that event would raise when called
    public UnityEvent<GameEventParameters> response = new UnityEvent<GameEventParameters>();

    private void OnEnable()
    {
        foreach (var ev in events)
        {
            if (ev == null) return;
            ev.RegisterEvent(this);
        }
    }

    private void OnDisable()
    {
        foreach (var ev in events)
        {
            if (ev == null) return;
            ev.DeRegisterEvent(this);
        }
    }

    private void OnDestroy()
    {
        foreach (var ev in events)
        {
            if (ev == null) return;
            ev.DeRegisterEvent(this);
        }
    }

    public void OnEventRaised(GameEventParameters caller)
    {
        response.Invoke(caller);
    }
}