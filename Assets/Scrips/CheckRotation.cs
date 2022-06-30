using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Oculus.Interaction;

public class CheckRotation : MonoBehaviour
{
    public TextMeshPro Textfield;
    public TextMeshPro Textfield1;
    public TextMeshPro Textfield2;

    private Vector3 oldRotation;
    private Vector3 currentRotation;


    private bool isRight = false;
    private float Rotations = 0;


    public float FrequenceBereichText = 100;
    public float Bereich = 10;

    private bool turnRight = false;
    

    public AudioSource Noice;
    public AudioSource Text;
    public AudioSource Text1;

    private void Start()
    {
        Text.volume = 0;
        Text1.volume = 0;

    }
    void Update()
    {
        if (true)//gameObject.GetComponent<Grabbable>()._activeTransformer != null)
        {
            oldRotation = currentRotation;
            currentRotation = transform.eulerAngles;

            Textfield.text = Mathf.Round(transform.eulerAngles.y) + "";

            /*
            isRight = GetRotateDirection(oldRotation, currentRotation);
            if (isRight == true)
                Textfield1.text = Mathf.Round(this.transform.rotation.eulerAngles.y) + "";
            if (isRight == false)
                Textfield1.text = Mathf.Round(this.transform.rotation.eulerAngles.y) + "";
            */

            if (currentRotation.y == 360)
                Rotations++;


            // 95 - 100
            // ( 95 - 100 >= 95  && 95 -100 <= 100
            if (currentRotation.y >= (FrequenceBereichText - (Bereich / 2)) && currentRotation.y <= FrequenceBereichText)
            {
                // (( 0 - 5 ) * ( 100/ ( 10 / 2)) /100
                Noice.volume = (((FrequenceBereichText - currentRotation.y) * (100 / (Bereich / 2))) / 100);
                Text.volume = 1-Noice.volume;
            }

            // 100 - 105
            if (currentRotation.y <= (FrequenceBereichText + (Bereich / 2)) && currentRotation.y >= FrequenceBereichText)
            {
                // (( 0 - 5 ) * ( 100/ ( 10 / 2)) /100
                Noice.volume = (((currentRotation.y - FrequenceBereichText) * (100 / (Bereich / 2))) / 100);
                Text.volume = 1-Noice.volume;
            }
            

            Textfield1.text = Mathf.Round(Noice.volume) + " V.Noice";
            Textfield2.text = Mathf.Round(Text.volume) + " V.Text";
            
            //if user is 2 Sek in FrequenceBereichText than start Audio Text 2
            while(currentRotation.y <= (FrequenceBereichText+1) || currentRotation.y >= (FrequenceBereichText - 1))
            {
                StartCoroutine(Wait2Sec());
                Text.volume = 0;
                Text1.volume = 1;
            }
            
        }
    }
    IEnumerator Wait2Sec()
    {
        yield return new WaitForSeconds(2);
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