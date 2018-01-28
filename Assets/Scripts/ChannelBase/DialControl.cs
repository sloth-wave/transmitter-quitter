using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialControl : MonoBehaviour {

    static float position = 0;

    // Converts the controller X Y position to a position in degrees
    public static float Position() {
        position += Input.GetAxis("Dial");
        return position;
    }

    public static float WrappedPosition()
    {
        position += Input.GetAxis("Dial");
        return position % 360;
    }

    public static float ClampedPosition(float position, float min, float max) {
        position += Input.GetAxis("Dial");
        position = Mathf.Clamp(position, min, max);
        return position;
    }

    // Gets the expected result of a position update without updating
    public static float getPosition() {
      return position + Input.GetAxis("Dial");
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

    public static float Direction() {
        float velocity = Velocity();
        if (velocity == 0)
            return 0;
        return Mathf.Sign(Velocity());
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
