using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointExt : MonoBehaviour
{
    float currentAngle;

    public float Speed = 1; 


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentAngle += Time.deltaTime * Speed; 
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            currentAngle += Time.deltaTime * -Speed;
        }

        transform.rotation = Quaternion.AngleAxis(currentAngle, Vector3.forward); 
    }
}
