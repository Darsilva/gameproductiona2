using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If press ESC exit game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitGame();
        }
    }
    void ExitGame()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }
}
