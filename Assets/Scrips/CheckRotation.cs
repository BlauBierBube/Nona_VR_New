using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckRotation : MonoBehaviour
{
    public TextMeshPro Textfield;
    public TextMeshPro Textfield1;

    private Vector3 oldRotation;
    private Vector3 currentRotation;


    private bool isRight = false;
    /*
    private float FrequenceBereichText = 100;
    private float Bereich = 10;
    private float Frequence = 360;
    private float Count = 0;
    private bool turnRight = false;
    */

    public AudioSource Noice;
    public AudioSource Text;


    void Update()
    {
        if (currentRotation != transform.eulerAngles)
        {
            oldRotation = currentRotation;
            currentRotation = transform.eulerAngles;
            Textfield.text = Mathf.Round(currentRotation.y) + "";
            isRight = GetRotateDirection(oldRotation, currentRotation);
            if (isRight == true)
                Textfield1.text = "Positiv";
            if (isRight == false)
                Textfield1.text = "Negativ";
        }
    }


    // return true if rotating clockwise
    // return false if rotating counterclockwise
    bool GetRotateDirection(Vector3 from, Vector3 to)
    {
        float fromY = from.y;
        float toY = to.y;
        float clockWise = 0f;
        float counterClockWise = 0f;

        if (fromY <= toY)
        {
            clockWise = toY - fromY;
            counterClockWise = fromY + (360 - toY);
        }
        else
        {
            clockWise = (360 - fromY) + toY;
            counterClockWise = fromY - toY;
        }
        return (clockWise <= counterClockWise);
    } 
}

    /*
    // Update is called once per frame
    void Update()
    {
        
        if(currentAngle != transform.localEulerAngles.y)
        {
            currentAngle = transform.localEulerAngles.y;

            Textfield.text = Mathf.Round(currentAngle) + "";


            if (currentAngle >= (FrequenceBereichText - (Bereich / 2)))
            {
            Noice.volume = (Noice.volume + (currentAngle - FrequenceBereichText) / 10);
            Textfield1.text = Noice.volume + " Volumen";
            //Debug.LogError(Noice.volume);
            }
            if (currentAngle <= (FrequenceBereichText + (Bereich / 2))) 
            {
            Noice.volume = (Noice.volume - (currentAngle - FrequenceBereichText) / 10);
            Textfield1.text = Noice.volume + " Volumen";
            }
            else
                Noice.volume = 1;
        }
}


