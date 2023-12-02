using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Regresar : MonoBehaviour
{
    public Button regresar;

    public GameObject electron;
    public Rigidbody2D electronForces;
    public GameObject startPosition;
    public Camera mainCamera;
    public Camera followingCamera;

    public GameObject cameraStartPosition;

    public LaunchLogic logica;
    
    // Start is called before the first frame update
    void Start()
    {
        regresar.onClick.AddListener(Regreso);
    }

    // Update is called once per frame
    void Regreso()
    {

        if (logica.lanzamientos > 0)
        {
            electronForces.velocity = Vector2.zero;
            electronForces.angularVelocity = 0;
            electron.transform.position = startPosition.transform.position;

            mainCamera.transform.position = cameraStartPosition.transform.position;
            mainCamera.gameObject.SetActive(true); // Disable the main camera
            followingCamera.gameObject.SetActive(false); // Enable the following camera
            followingCamera.GetComponent<CameraFollow>().followObject = false; // Start following the object
        }
        else
        {
      
            SceneManager.LoadScene("Resultados");
            Debug.Log("Fin");
        }
        
    }
}
