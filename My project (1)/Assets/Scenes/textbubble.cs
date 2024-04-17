using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textbubble : MonoBehaviour
{
   private SpriteRenderer backgroundSpriteRenderer;
   private TextMeshPro textMeshPro;

    private void Awake()
    {
        backgroundSpriteRenderer = transform.Find("background").GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find ("text").GetComponent <TextMeshPro>();
    }

    private void Start()
    {
        Setup("Hello World!");
    }

    private void Setup(string text)
    {
        textMeshPro.SetText (text);
        textMeshPro.ForceMeshUpdate ();
        Vector2 textSize = textMeshPro.GetRenderedValues(false);

        Vector2 padding = new Vector2(4f, 2f);
        backgroundSpriteRenderer. size = textSize + padding;
    }

}
