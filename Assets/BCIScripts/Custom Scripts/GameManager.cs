using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGameManager : MonoBehaviour
{
    public int nCalibrationTrials = 10;
    public int nPredictionTrials = 10;

    void Start()
    {
        InitializeBCI();
    }

    void InitializeBCI()
    {
        NoisetagController nt = NoisetagController.Instance;
        if (nt == null)
        {
            Debug.LogError("NoisetagController instance not found!");
            return;
        }

        // Register events
        nt.sequenceCompleteEvent.AddListener(OnSequenceComplete);
        nt.connectedEvent.AddListener(OnConnected);

        // Start the calibration process
        //StartCalibration();
        StartPrediction();

    }

    void StartCalibration()
    {
        NoisetagController nt = NoisetagController.Instance;
        nt.startCalibration(nCalibrationTrials);
    }

    void StartPrediction()
    {
        NoisetagController nt = NoisetagController.Instance;
        nt.startPrediction(nPredictionTrials);
    }

    void OnSequenceComplete()
    {
        Debug.Log("Sequence Complete");
        // Optionally start prediction after calibration
        StartPrediction();
    }

    void OnConnected()
    {
        Debug.Log("BCI Connected");
    }
/*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.anyKeyDown && NoisetagController.Instance.isRunning)
        {
            NoisetagController.Instance.stopFlicker();
            NoisetagController.Instance.modeChange("idle");
        }
    }*/
}