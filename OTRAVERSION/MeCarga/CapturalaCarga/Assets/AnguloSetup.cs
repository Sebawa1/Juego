using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class AnguloSetup : MonoBehaviour
{
    public GameObject canon;
    public Slider setupAngle;
    public float Angle;

    // Update is called once per frame
    void Update()
    {
        Angle = setupAngle.value;
        canon.transform.rotation = Quaternion.Euler(0,0,-setupAngle.value);
    }
}
