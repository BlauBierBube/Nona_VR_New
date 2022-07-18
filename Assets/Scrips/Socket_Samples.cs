using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using Oculus.Interaction;


public class Socket_Sample : MonoBehaviour
{
    public LayerMask Sample_1;
    public LayerMask Sample_2;
    public LayerMask Sample_3;



    public UnityEvent SelectEnter;
    public UnityEvent SelectExit;

    private int count = 0;


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    { 

    }

    private void OnTriggerEnter(Collider other)
    {
        // Check Layer 
        if ((Sample_1.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            
        }
    }


   




}