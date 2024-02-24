using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScript : MonoBehaviour
{
    //camera to transform
    private Transform cameraTransform;

    //last camera position
    private Vector3 lastcameraPos;

    private void Start()
    {   
        //capturing the main camera
        cameraTransform = Camera.main.transform;
        //making the position equal to the camera transform position
        lastcameraPos = cameraTransform.position;
    }
    
    //function to make sure this runs after the camera moves
    private void LateUpdate()
    {   
        //how much the camera has moved since the pervious frame
        Vector3 deltaMovement = cameraTransform.position = lastcameraPos;
        //adding the transform position to delta
        transform.position += deltaMovement;
        //resetting the position
        lastcameraPos = cameraTransform.position;
    }
}
