﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialControl : MonoBehaviour {

    static float position = 0;
    //Converts the controller X Y position to a position in degrees

    public static float Position() {
        position += Input.GetAxis("Dial");
        return position;
    }

    private static float lastPos = 0;
    public static float Velocity() {
        float velocity = (DialControl.Position() - lastPos) / Time.deltaTime;
        lastPos = DialControl.Position();
        return velocity;
    }

    private static float lastVel = 0;
    public static float Acceleration() {
        float acceleration = (DialControl.Velocity() - lastVel) / Time.deltaTime;
        lastVel = DialControl.Velocity();
        return acceleration;
    }

    public static bool GetButtonDown() {
        return Input.GetButtonDown("DialButton");
    }

    public static bool GetButtonUp(){
        return Input.GetButtonDown("DialButton");
    }

    public static bool GetButton(){
        return Input.GetButtonDown("DialButton");
    }

    public static void reset() {
        position = 0;
    }
}