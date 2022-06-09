using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Power_Switch : MonoBehaviour
{
    private float targetRotation = 50;
    public TextMeshPro Textfeld;

    public UnityEvent onSolved;

    // Start is called before the first frame update
    void Start()
    {
        Textfeld.text = "Power Off";
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }

    public void FreezeNone()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    public void FreezeAll()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;


        if (Mathf.Round(transform.eulerAngles.x) > targetRotation)
        {
            Textfeld.text = "Power On";
            onSolved.Invoke();
        }
    }
}
