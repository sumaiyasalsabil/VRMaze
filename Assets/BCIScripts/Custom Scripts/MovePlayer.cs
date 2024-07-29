using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;
//using Unity.XR.CoreUtils;

public class MovePlayer : MonoBehaviour
{
    public CharacterController characterController;
    private Vector3 moveTo;
    [SerializeField] private float movementSpeed;
    private Vector3 turnDirection;
    [SerializeField] private Vector3 turnLeft;
    [SerializeField] private Vector3 turnRight;
    private GameObject xrOrigin;
    [SerializeField] private GameObject BCIControls;

    private void Awake()
    {
        turnLeft = new Vector3(0f, -90f, 0f);
        turnRight = new Vector3(0f, 90f, 0f);
        BCIControls = GameObject.Find("BCI Controls");

        xrOrigin = GameObject.Find("XR Origin (XR Rig)");
        characterController = xrOrigin.GetComponent<CharacterController>();
    }


    public void MoveForward()
    {
        // Move forward [along the gameobject's Z axis] at a certain speed
        moveTo = transform.forward * Time.deltaTime * movementSpeed;
        Debug.LogWarning("Current: " + transform.position);
        Debug.LogWarning("Moving forward: " + moveTo);

        // Retrieve player's character controller component
        characterController.Move(moveTo); // this move is constrained by collisons in the environment

        HideObject();

    }

    [Tooltip("Type in either \"L\" or \"R\"")]
    public void Turn(string direction)
    {
        // Rotate [along the gameobject's Y axis] to the left by -90�, or to the right by 90�
        turnDirection = direction == "L" ? turnLeft : turnRight;
        transform.Rotate(turnDirection * Time.deltaTime * movementSpeed, Space.World);

        HideObject();

        /*
        turnAngle = direction == "L" ? -90f : 90f;
        transform.Rotate(0f, turnAngle, 0f, Space.World);
        */
    }

    private void HideObject()
    {
        // Hide arrows for 2 seconds after movement
        BCIControls.SetActive(false);
        Invoke(nameof(ShowObject), 2);
    }

    private void ShowObject()
    {
        BCIControls.SetActive(true);
    }
}
