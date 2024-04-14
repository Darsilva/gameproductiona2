using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class CubeController : MonoBehaviour
{
    // Static list to keep track of all spawned cube GameObjects
    private static List<GameObject> spawnedCubes = new List<GameObject>();

    // Add the cube GameObject to the list when spawned
    void Start()
    {
        spawnedCubes.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the shift key is pressed
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            // Check if there are any cubes spawned
            if (spawnedCubes.Count > 0)
            {
                // Destroy the last cube GameObject in the list
                Destroy(spawnedCubes[spawnedCubes.Count - 1]);
                // Remove the destroyed cube GameObject from the list
                spawnedCubes.RemoveAt(spawnedCubes.Count - 1);
            }
        }
    }
}