using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public Button cambiarEscena;

    public string nombreEscena;
    // Start is called before the first frame update
    void Start()
    {
        cambiarEscena.onClick.AddListener(Cambio);
    }

    // Update is called once per frame
    void Cambio()
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
