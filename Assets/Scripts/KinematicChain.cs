using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

[ExecuteInEditMode]
public class KinematicChain : MonoBehaviour
{
    [SerializeField, Range(-180.0f, 180.0f)]
    private float[] values; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var elements = gameObject.GetComponentsInChildren<KinematicJoint>(); 
        // Array.Reverse(elements); 

        if (values == null || values.Length != elements.Length) {
            values = new float[elements.Length]; 
        }

        for (int i=0; i<values.Length; ++i) {
            elements[i].AngleDeg = values[i]; 
        }
    }

    /// <summary>
    /// Called when the script is loaded or a value is changed in the
    /// inspector (Called in the editor only).
    /// </summary>
    void OnValidate()
    {
    }
}
