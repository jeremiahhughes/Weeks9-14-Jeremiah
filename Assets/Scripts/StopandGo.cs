using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StopandGo : MonoBehaviour
{
    public UnityEvent Stop;
    public UnityEvent Go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Go.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Stop.Invoke();
        }
    }

    public void Gogo()
    {
        Input.GetKeyDown(KeyCode.Mouse0);
        Debug.Log("GOO");
    }

    public void Stopstop()
    {
        Input.GetKeyDown(KeyCode.Mouse1);
        Debug.Log("Stopppp");
    }
}
