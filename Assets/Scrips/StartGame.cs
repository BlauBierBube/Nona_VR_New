using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    public AudioSource Explosion;

    // Start is called before the first frame update
    void OnLevelWasLoaded()
    {
        Invoke("startgame", 10f);
    }

    public void Vibrate()
    {
        OVRInput.SetControllerVibration(0.5f, 0.8f, OVRInput.Controller.All);
    }

    public void startgame()
    {
        OVRInput.SetControllerVibration(0.5f, 0.8f, OVRInput.Controller.All);
        Explosion.Play();
    }
}
