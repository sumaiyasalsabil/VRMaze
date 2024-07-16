using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NoisetagController nt = FindObjectOfType<NoisetagController>();
        if (nt == null)
        {
            Debug.LogError("Noisetag Controller instance not found.");
            return;
        }

        nt.startPrediction(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
