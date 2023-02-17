using UnityEngine;

public class TestCube : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            EventsManager.Instance.RaiseEvent("Shoot");
        }
    }

    public void OnShootEventRaised()
    {
        Debug.Log("Shoot Now");
    }
}
