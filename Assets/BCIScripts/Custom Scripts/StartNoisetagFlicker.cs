using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNoisetagFlicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NoisetagController.Instance.startPrediction(10);
    }

    /*
    // Update is called once per frame
    void Update()
    {

        NoisetagController.Instance.startPrediction(10);
    }
    */
}
