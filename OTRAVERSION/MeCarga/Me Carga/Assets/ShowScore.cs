using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ShowScore : MonoBehaviour
{

    public TMP_Text maxScore;

    public TMP_Text currentScore;
    // Start is called before the first frame update
    void Start()
    {
        maxScore.text = "Mejor Puntaje : "+RealGlobal.Instance.maxScore.ToString();
        currentScore.text = "Tu Puntaje : "+RealGlobal.Instance.placeHolderScore.ToString();
    }

}
