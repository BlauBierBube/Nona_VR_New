using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckRotation : MonoBehaviour
{
    public TextMeshPro Textfield;
    private Vector3 currentAngle;
    private Vector3 lastAngle;

    // Update is called once per frame
    void Update()
    {
        if(currentAngle != transform.localEulerAngles)
        {
            lastAngle = currentAngle;
            currentAngle = transform.localEulerAngles;

            float Angle = Mathf.Sign(Vector3.SignedAngle(lastAngle, currentAngle, Vector3.up));
            // Debug.LogError(Angle);


            // is 1 if its positive and -1 if its negative
            if (Angle == 1f) // Positiv
            {

                Textfield.text = Mathf.Round(transform.localEulerAngles.y) + "";
                //Debug.LogError("Rotation is Positive");
            }
            if(Angle == -1f) // Negativ
            {
                Textfield.text = Mathf.Round(transform.localEulerAngles.y) + "";
                //Debug.LogError("Rotation is Negative");
            }
        }
    }
}
