using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using Oculus.Interaction;


public class CustomSoket : MonoBehaviour
{
    public LayerMask Layer;
    public GameObject Attach;
    public Material HoverMat;



    public UnityEvent SelectEnter;
    public UnityEvent SelectExit;

    private int count = 0;
    private GameObject Target;
    private GameObject hoverObject;
    private GameObject realObject;
    private bool wasInSoket = false;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    { 

    }

    private void OnTriggerStay(Collider other)
    {
        // Check Layer 
        if ((Layer.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            //Debug.LogError(other.gameObject.name +" Hit with Layermask");
            Target = other.gameObject;
            HoverObject();
            if (Target.GetComponentInParent<Grabbable>()._activeTransformer != null && wasInSoket == true)
            {
                count = 0;
                SelectExit.Invoke();
                wasInSoket = false;
            }

            if (Target.GetComponentInParent<Grabbable>()._activeTransformer == null)
            {
                PlaceAtSoket();
            }
        }
    }
    private void PlaceAtSoket()
    {

        if (count == 0)
        {
            DestroyHoverObject();

            Target.transform.parent = Attach.transform;
            Target.transform.rotation = Attach.transform.rotation;
            Target.transform.position = Attach.transform.position;

            SelectEnter.Invoke();

            wasInSoket = true;
            count = 1;
        }
    }



    private void HoverObject()
    {
        if(hoverObject == null && wasInSoket == false)
        {
            //Debug.LogError("Hover Active");
            hoverObject = Instantiate(Target, Attach.transform.position, Attach.transform.rotation);
            hoverObject.transform.parent = Attach.transform;
            hoverObject.layer = 0;
            hoverObject.GetComponent<Collider>().enabled = false;
            hoverObject.GetComponent<MeshRenderer>().material = HoverMat;
        }
    }
    private void DestroyHoverObject()
    {
        if (hoverObject)
        {
            //Debug.LogError("Hover Inactive");
            Destroy(hoverObject);
        }
    }




    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        if ((Layer.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            DestroyHoverObject();
            
        }
    }
}