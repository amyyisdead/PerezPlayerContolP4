using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Properler : MonoBehaviour
{
    private float propeller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.E))
        {
            propeller = 1f;

        }
        else
        {
            propeller = 0f;
        }
        transform.Rotate(Vector3.forward * propeller * Time.deltaTime * 500f);
    }
}
