using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class BCISelectable : MonoBehaviour
{
    public Transform player;
    public Vector3 direction = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        XROrigin origin = FindObjectOfType<XROrigin>();
        if (origin != null)
        {
            player = origin.transform;
        }
        else
        {
            Debug.LogError("XR Origin not found.");
        }
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public void HandleBCISelection()
    {
        if (player != null)
        {
            Debug.Log($"{gameObject.name} has been selected.");
            player.position += direction;
        }
    }
}
