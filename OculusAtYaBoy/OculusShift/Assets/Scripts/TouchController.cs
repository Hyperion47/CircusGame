using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {

    public OVRInput.Controller Controller;

    // Update is called once per frame
    void Update () {
        OVRInput.Update();
        transform.localPosition = (OVRInput.GetLocalControllerPosition(Controller) * 10);
        transform.localRotation = OVRInput.GetLocalControllerRotation(Controller);
    }
}
