using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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
            t = 0;
            OnTimerHasFinished.Invoke();
        }
    }

    public void MouseJustEnteredImage()
    {
        Debug.Log("Mouse Just entered me!");
        banana.localScale = Vector3.one * 1.2f;
    }

    public void MouseJustLeftImage()
    {
        Debug.Log("Mouse Just left me!");
        banana.localScale = Vector3.one;
    }
}
