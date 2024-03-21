using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFullScreen : MonoBehaviour
{
    private bool isFullscreen = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleFullscreen();
        }
    }
    void ToggleFullscreen()
    {
        isFullscreen = !isFullscreen; // Toggle the state
        Screen.fullScreen = isFullscreen; // Apply the change
        Debug.Log("FULLSCREEN ACTIVATED");
    }
}
