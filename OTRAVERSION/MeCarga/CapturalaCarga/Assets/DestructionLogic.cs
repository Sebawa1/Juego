using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine.SceneManagement;

public class DestructionLogic : MonoBehaviour
{
    public int scoreToGive;
    public GlobalVariables globales;
    public bool Destructive;
    private void Start()
    {
        globales = GameObject.FindGameObjectWithTag("globales").GetComponent<GlobalVariables>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Proyectil")) // Make sure the tag matches your objects
        {
            if (!Destructive)
            {
                globales.currentScore += scoreToGive;
                Destroy(this.gameObject); // Destroy the object upon collision
            }

            else
            {
                SceneManager.LoadScene("Resultados");
                Debug.Log("Fin");
            }

        }
    }
}
