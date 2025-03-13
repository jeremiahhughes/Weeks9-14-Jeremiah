using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EventDemo : MonoBehaviour
{
    public RectTransform banana;
    public UnityEvent OnTimerHasFinished;
    public float timerLength = 3;
    public float t;


    private void Update()
    {
        t += Time.deltaTime;
        if(t > timerLength)
        {
            OnTimerHasFinished.Invoke();
            t = 0;
        }
    }

    public void PointerOnUs()
    {
        banana.localScale = Vector3.one * 1.2f;
        Debug.Log("The mouse has entered");
    }

    public void PointerNotOnUs()
    {
        banana.localScale = Vector3.one;
        Debug.Log("The mouse is not on us");
    }
}
