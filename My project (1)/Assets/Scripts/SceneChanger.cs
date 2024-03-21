using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Press Space for changing scene
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeScene();
        }
    }
    void ChangeScene()
    {
        if (SceneManager.GetActiveScene().name == "FirstScene")
        {
            SceneManager.LoadScene("SecondScene");
        }
        else if (SceneManager.GetActiveScene().name == "SecondScene")
        {
            SceneManager.LoadScene("FirstScene");
        }
    }

}
