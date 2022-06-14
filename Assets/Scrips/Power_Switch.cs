using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Power_Switch : MonoBehaviour
{
    private float targetRotation = -40;
    public TextMeshPro Textfeld;


    public UnityEvent onSolved;

    // Start is called before the first frame update
    void Start()
    {
        Textfeld.text = "Power Off";
    }

    private void Update()
    {
        if (transform.eulerAngles.x == targetRotation)
        {
            Textfeld.text = "Power On";
            Debug.LogError("Power ON");
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            onSolved.Invoke();
        }
    }
}
