using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealGlobal : MonoBehaviour
{
    public static RealGlobal Instance { get; private set; }

    public int maxScore;
    public int placeHolderScore;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // Ensures only one instance exists
        }
    }
}
