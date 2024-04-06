using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructCoroutine : MonoBehaviour
{
    public float delay = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestructAfterDelay());
    }
    IEnumerator SelfDestructAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Destroy this GameObject
        Destroy(gameObject);
    }
}
