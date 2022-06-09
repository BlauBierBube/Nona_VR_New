using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tresor_Open : MonoBehaviour
{
    public TextMeshPro TresorTextObject;
    public string TresorText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FreezeAll()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll; 
    }

    public void UnfreezeAll()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        TresorTextObject.text = TresorText;
    }


}
