using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
public class LeverPositionTarget : MonoBehaviour
{
    private float targetPosition = 0.09f;
    public TextMeshPro Textfeld;

    public UnityEvent onSolved;

    // Start is called before the first frame update
    private void Update()
    {
        if (transform.localPosition.y >= targetPosition)
        {
            Debug.Log("PositionReached.");
            LeverPushed();
        }
    }

    private void LeverPushed()
    {
        Textfeld.text = "RETTUNKSKAPSEL ABDOCKEN";

        onSolved.Invoke();
    }
}
