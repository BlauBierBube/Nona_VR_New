using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        VibrationManager.singleton.TriggerVibration(40, 2, 255, OVRInput.Controller.All);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
