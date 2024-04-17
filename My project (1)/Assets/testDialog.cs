using cherrydev;
using System.Runtime.CompilerServices;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogGraph;

    private void Start()
    {
        dialogBehaviour.StartDialog(dialogNodeGraph: dialogGraph);
    }
}