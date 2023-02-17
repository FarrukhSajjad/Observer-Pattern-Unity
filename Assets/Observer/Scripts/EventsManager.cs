using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public List<GameEvent> gameEvents = new List<GameEvent>();

    public static EventsManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Call this function with the corrent event name and optional game event parameters
    public void RaiseEvent(string eventName, GameEventParameters caller = null)
    {
        foreach (var gameEvent in gameEvents)
        {
            if (eventName != gameEvent.name) continue;

            gameEvents.Single(currentGameEvent => currentGameEvent.name == eventName).RaiseEvent(caller);
            return;
        }

        Debug.LogError($"{eventName} This Game Event Name Does Not Exists");
    }
}