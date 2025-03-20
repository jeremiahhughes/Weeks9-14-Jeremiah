using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KitClock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public float timeAnHourTakes = 5;

    public float t;
    public int hour = 0;

    public UnityEvent<int> OnTheHour;

    Coroutine ClockIsRunning;
    IEnumerator doOneHour;

    void Start()
    {
        ClockIsRunning = StartCoroutine(MoveTheClock());
    }

    IEnumerator MoveTheClock()
    {
        while(true)
        {
            doOneHour = MoveTheClockHandOneHour();
            yield return StartCoroutine(doOneHour);
        }
    }

    IEnumerator MoveTheClockHandOneHour()
    {
        t = 0;
        while(t < timeAnHourTakes)
        {
            t += Time.deltaTime;
            minuteHand.Rotate(0, 0, -(360 / timeAnHourTakes) * Time.deltaTime);
            hourHand.Rotate(0, 0, -(30 / timeAnHourTakes) * Time.deltaTime);
            yield return null;
        }
        hour++;
        if(hour == 13)
        {
            hour = 1;
        }
        OnTheHour.Invoke(hour);
    }

    public void StopTheClock()
    {
        if(ClockIsRunning != null)
        {
            StopCoroutine(ClockIsRunning);
        }

        if (ClockIsRunning != null)
        {
            StopCoroutine(doOneHour);
        }
    }
}
