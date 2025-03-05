
using System;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        Debug.Log(message: "第一個Start");
    }

    private void Awake()
    {
        Debug.Log(message:$"Awake");
    }

    private void OnEnable()
    {
        Debug.Log(message:$"OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log(message:$"OnDisable");
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(message:$"OnCollisionEnter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
