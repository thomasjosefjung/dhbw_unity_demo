using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicJoint : MonoBehaviour
{
    [Range(-180.0f, 180.0f)]
    public float AngleDeg = 0.0f;

    [Range(-180.0f, 180.0f)]
    public float Speed = 45f;

    public bool KeyboardControl = false; 

    // Start is called before the first frame update
    void Start()
    {
        current = 0.0f; 
    }


    float current; 
    float currentVel; 

    // Update is called once per frame
    void Update()
    {
        if (KeyboardControl)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                AngleDeg = AngleDeg - Time.deltaTime * Speed;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                AngleDeg = AngleDeg + Time.deltaTime * Speed;
            }
        }

        //transform.localRotation = Quaternion.AngleAxis(AngleDeg, Vector3.forward);
        current = Mathf.SmoothDampAngle(current, AngleDeg, ref currentVel, 1f, float.MaxValue);
        transform.localRotation = Quaternion.AngleAxis(current, Vector3.forward);
    }

    /// Called when the script is loaded or a value is changed in the
    /// inspector (Called in the editor only).
    void OnValidate()
    {
        
    }
}
