using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CambiarCarga : MonoBehaviour
{
    public Button cambiarCarga;
    public TMP_Text boton;
    public AttractionLogic electron;
    // Start is called before the first frame update
    void Start()
    {
        cambiarCarga.onClick.AddListener(Cambio);
        Estado();
    }

    void Cambio()
    {
        electron.carga = electron.carga * -1;
        electron.ChangeSprite();
        Estado();
    }

    void Estado()
    {
        if (electron.carga > 0)
        {
            boton.text = "+";
        }
        else
        {
            boton.text = "-";
        }
    }
}
