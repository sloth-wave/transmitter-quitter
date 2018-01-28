using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGame : MonoBehaviour {

    public float sensitivity = 5;
    public float speed = 6f;

    public bool  limitRotation  = false;
    public float maxRotation    = 0;
    public float minRotation    = 0;

	   // Update is called once per frame
     void Update () {
         if(CanRotate()){
          Rotate();
         }
	   }

     // Check if the expected new position of the object is with the set min/max bounds
     bool CanRotate(){
       if(limitRotation){
         // The position we expect to end up in if we allow rotation
         float  new_position = DialControl.getPosition() * sensitivity;
         return new_position > minRotation && new_position < maxRotation;
       }
       else{
         return true;
       }
     }

     void Rotate (){
       float position          = DialControl.Position() * sensitivity;
       Quaternion rotation     = this.transform.rotation;
       rotation.eulerAngles    = new Vector3(rotation.eulerAngles.x, rotation.eulerAngles.y, position);
       this.transform.rotation = Quaternion.Lerp(this.transform.rotation, rotation, speed * Time.deltaTime);
     }
}
