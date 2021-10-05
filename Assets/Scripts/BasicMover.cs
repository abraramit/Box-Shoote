using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitute = 0.1f;

    public bool doSpin = true;
    public bool doMotion = true;

    // Update is called once per frame
    void Update()
    {
        if (doSpin){
            //Rotate around the up axis of the gameObject 
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }

        if (doMotion){
            //Move up and down over time
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitute);
        }
        
    }
}
