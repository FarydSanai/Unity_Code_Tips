using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void Start()
    {
        Debug.Log("Start");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
}
