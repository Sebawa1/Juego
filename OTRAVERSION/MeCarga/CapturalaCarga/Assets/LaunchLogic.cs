using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LaunchLogic : MonoBehaviour
{
    public AnguloSetup angulo;

    public GameObject cannon;
    public Rigidbody2D ballObject;
    public Button lanzar;

    public Slider fuerza;

    public int lanzamientos;
    public TMP_Text lanzamientosText;
    
    public Camera mainCamera;
    public Camera followingCamera;

    
    // Start is called before the first frame update
    void Start()
    {
        lanzar.onClick.AddListener(OnButtonPressed);
    }



    void OnButtonPressed()
    {
    
        ballObject.AddForce(cannon.transform.up * fuerza.value, ForceMode2D.Impulse);
        mainCamera.gameObject.SetActive(false); // Disable the main camera
        followingCamera.gameObject.SetActive(true); // Enable the following camera
        followingCamera.GetComponent<CameraFollow>().followObject = true; // Start following the object

        lanzamientos -= 1;
        lanzamientosText.text = lanzamientos.ToString();

    }
    
}
