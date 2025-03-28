using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        hoodCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

       

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
