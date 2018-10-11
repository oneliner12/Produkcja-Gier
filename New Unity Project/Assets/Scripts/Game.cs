using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
       Scheduler._Instance.Scheduleparameter(4, "delay message");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
