using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalVariables : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text maxScoreText;
    public int currentScore;

    private void Start()
    {
        maxScoreText.text = "Mejor Puntaje : " + RealGlobal.Instance.maxScore.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RealGlobal.Instance.placeHolderScore = currentScore;
        score.text = currentScore.ToString();
        if (currentScore > RealGlobal.Instance.maxScore)
        {
            RealGlobal.Instance.maxScore = currentScore;
            maxScoreText.text = "Mejor Puntaje : " + RealGlobal.Instance.maxScore.ToString();
        }
    }
}
