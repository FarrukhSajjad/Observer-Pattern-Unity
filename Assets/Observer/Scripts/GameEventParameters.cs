using UnityEngine;

public class GameEventParameters
{
    public int IntegerEventValue;
    public float FloatEventValue;
    public GameObject GameObjectEventValue;
    public string StringEventValue;

    public GameEventParameters(int integerEventValue = default, float floatEventValue = default,
        GameObject gameObjectEventValue = default, string stringEventValue = default)
    {
        IntegerEventValue = integerEventValue;
        FloatEventValue = floatEventValue;
        GameObjectEventValue = gameObjectEventValue;
        StringEventValue = stringEventValue;
    }
}