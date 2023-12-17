using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{


    public bool isOn;
    public Light light1;
    public Light light2;
    public AudioSource source;
    public AudioClip ClickSound;
    // Update is called once per frame
    void Update()
    {

        light1.enabled = isOn;
        light2.enabled = isOn;

        if (Input.GetKeyDown(KeyCode.E))
        {
            isOn = !isOn;

            source.PlayOneShot(ClickSound);
        }
    }
}
