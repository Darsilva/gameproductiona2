using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float countdown = 5f;
    // Update is called once per frame
    void Update()
    {
        // Decrease the countdown based on the time passed since the last frame
        countdown -= Time.deltaTime;

        if (countdown <= 0f)
        {
            Destroy(gameObject); // Destroy this GameObject
        }
    }
}
