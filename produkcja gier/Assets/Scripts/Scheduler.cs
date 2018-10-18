using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Scheduler : MonoBehaviour {

    private void Awake()
    {
        _Instance = this;
    }
    public void Start()
    {

    }
    public static Scheduler _Instance { get; private set; }

    public void Scheduleparameter(float delay, Action action)
    {
        Debug.Log("delay is " + delay);
        StartCoroutine(RunDelay(delay,action));

    }

    private IEnumerator RunDelay(float delay,Action action)
    {
        yield return new WaitForSeconds(delay);
        action();
        Debug.Log("DelayedAttribute message:" + action);

    }
}
