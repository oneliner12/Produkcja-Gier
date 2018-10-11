using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scheduler : MonoBehaviour {

    private void Awake()
    {
        _Instance = this;
    }
    public void Start()
    {

    }
    public static Scheduler _Instance { get; private set; }

    public void Scheduleparameter(float delay, string message)
    {
        Debug.Log("delay is " + delay);
        StartCoroutine(RunDelay(delay, message));
    }

    private IEnumerator RunDelay(float delay, string message)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("DelayedAttribute message:" + message);

    }
}
