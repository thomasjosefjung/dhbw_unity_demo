using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolators : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;

    public int Interpolator = 1;

    Vector3 current_v;
    float current_t = 0.0f;

    public float SmoothTime = 5.0f;

    private Vector3 startPoint; 

    void Start()
    {
        current_t = 0.0f;
        startPoint = gameObject.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        switch(Interpolator)
        {
            case 1:
                {
                    current_t += 1f/SmoothTime * Time.deltaTime;
                    gameObject.transform.position = Vector3.Lerp(startPoint, Target.position, current_t); 
                    break; 
                }
            case 2:
                {
                    gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, Target.position, ref current_v, SmoothTime); 
                    break;
                }
            case 3:
                {
                    current_t += 1f / SmoothTime * Time.deltaTime;
                    gameObject.transform.position = Vector3.Slerp(startPoint, Target.position, current_t); 
                    break;
                }
        }
    }
}
