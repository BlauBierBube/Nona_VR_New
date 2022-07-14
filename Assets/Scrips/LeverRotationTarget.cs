using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class LeverRotationTarget : MonoBehaviour
{
    private float targetRotation = 309;
    public TextMeshPro Textfeld;

    public UnityEvent onSolved;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.localEulerAngles.x >= targetRotation)
        {
            Debug.Log("RotationReached.");
            LeverPulled();
        }
    }

    private void LeverPulled()
    {
        Textfeld.text = "RETTUNGSKAPSEL ERFOLGREICH GELÖST - GUTE REISE";

        onSolved.Invoke();
    }
}
