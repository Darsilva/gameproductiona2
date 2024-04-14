using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeVisibilityController : MonoBehaviour
{
    // Reference to the cube GameObject
    public GameObject cubeObject;

    // Variable to keep track of whether the cube is currently visible
    private bool isCubeVisible = true;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the cube is initially visible
        cubeObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the Q key is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Toggle the visibility of the cube
            isCubeVisible = !isCubeVisible;
            cubeObject.SetActive(isCubeVisible);

            // Debug log to check if the "Q" key is being pressed
            Debug.Log("Q key pressed. Cube visibility toggled.");
        }
    }
}