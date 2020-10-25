using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.transform.position += 0.1f * (gameObject.transform.rotation * new Vector3(0, 0, 1));
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                gameObject.transform.position -= 0.1f * (gameObject.transform.rotation * new Vector3(0, 0, 1));
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.position -= 0.1f * (gameObject.transform.rotation * new Vector3(1, 0, 0));
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.position += 0.1f * (gameObject.transform.rotation * new Vector3(1, 0, 0));
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.transform.rotation = Quaternion.AngleAxis(-1, gameObject.transform.rotation * new Vector3(1,0,0)) * gameObject.transform.rotation; 
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                gameObject.transform.rotation = Quaternion.AngleAxis(1, gameObject.transform.rotation * new Vector3(1,0,0)) * gameObject.transform.rotation; 
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.rotation = Quaternion.AngleAxis(-1, gameObject.transform.rotation * new Vector3(0,1,0)) * gameObject.transform.rotation; 
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.rotation = Quaternion.AngleAxis(1, gameObject.transform.rotation * new Vector3(0,1,0)) * gameObject.transform.rotation; 
            }
        }
    }
}
