﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightControllerPos : MonoBehaviour {

	// Use this for initialization
	public OSC osc;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 OscMessage message = new OscMessage();

        message.address = "/RightXYZ";
        message.values.Add(transform.position.x);
        message.values.Add(transform.position.y);
        message.values.Add(transform.position.z);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/RightX";
        message.values.Add(transform.position.x);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/RightY";
        message.values.Add(transform.position.y);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/RightZ";
        message.values.Add(transform.position.z);
        osc.Send(message);
	}
}
