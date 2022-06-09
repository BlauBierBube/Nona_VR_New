using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using Oculus.Interaction;


public class CustomSoket : MonoBehaviour
{
    public LayerMask Layer;
    public GameObject Attach;



    public UnityEvent SelectEnter;


    private GameObject Target;
    private bool ObjectIsinCollider = false;
    private bool ObjectNotGrabbed = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectIsinCollider && ObjectNotGrabbed)
        {
            Debug.LogError("Not Grabbed & in Collider");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // Check Layer 
        if ((Layer.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            Debug.LogError("Hit with Layermask");
            ObjectIsinCollider = true;
            Target = other.transform.gameObject;
            if(Target.GetComponent<Grabbable>()._activeTransformer == null)
            {
                ObjectNotGrabbed = true;
            }
        }
    }
}