# Observer-Pattern-Unity

Observer pattern is used to allow some objects to notify others about the changes without directly referencing them, thereby creating less dependencies and loosely coupled code.

When one subject changes it notifies all its dependant objects.

## How to use this package:

This package includes 2 mono behavior scripts that you will need to attach to two different game object in your scene, i.e., EventsManager and EventListener

### EventsManager:
Events Manager will be responsible to raise the events you have created and added in your game.

### EventListener:
Event Listener will be responsible to listen and generate the response to that corresponding event that you just raised.

There are two addition scripts, i.e., GameEvents and GameEventsParameters.

### GameEvents:
This will allow you to create game events in your unity editor.
Simply right click in your assets window and goto game event. Create Game event and rename it whatever you want

### GameEventParameters:
The parameters that you want to pass through when you raise an event.


## How to raise an event:
```
    EventsManager.Instance.RaiseEvent("EventName");
```


### How to add response for the events:
In the events listener game object add the event in the list and click on add response for that event.
Start adding the response for that particular event just like you do with regular unity event (For example, as in button click unity event).

### Optional:
You can also pass optional game event parameters when raising an event.
```
    EventsManager.Instance.RaiseEvent("EventName" , new GameEventParameters(0,0,null, null));
```

## Download the Package:
[Unity Package - Observer Pattern](https://github.com/FarrukhSajjad/Observer-Pattern-Unity/blob/master/ObserverPattern.unitypackage)

| RELEASE  | DATE |
| ------------- | ------------- |
| v0.0.01  | Feb 20th, 2023  |
