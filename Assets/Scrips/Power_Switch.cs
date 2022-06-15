using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Power_Switch : MonoBehaviour
{
    private float targetRotation = 80;
    public TextMeshPro Textfeld;

    private bool isActiv = false;
    public UnityEvent onSolved;

    // Start is called before the first frame update
    void Start()
    {
        Textfeld.text = "Power Off";
    }

    private void Update()
    {
        if (transform.localEulerAngles.x >= targetRotation && isActiv == false)
        {
            PowerOn();
        }
    }
    private void PowerOn()
    {
        Textfeld.text = "Power On";
        Debug.LogError("Power ON");
        onSolved.Invoke();
        isActiv = true;
    }
}
