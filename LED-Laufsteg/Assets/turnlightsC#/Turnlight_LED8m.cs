using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnlight_LED8m : MonoBehaviour
{
    public GameObject light0;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    private bool on = false;
    // Use this for initialization
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !on)
        {
            light0.SetActive(true);
            light1.SetActive(true);
            light2.SetActive(true);
            light3.SetActive(true);
            light4.SetActive(true);
            on = true;
        }
        else if (Input.GetKeyDown(KeyCode.Z) && on)
        {
            light0.SetActive(false);
            light1.SetActive(false);
            light2.SetActive(false);
            light3.SetActive(false);
            light4.SetActive(false);
            on = false;
        }
    }
}
