using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public CharacterController characterController;
    private Vector3 moveTo;
    [SerializeField]
    private float movementSpeed;
    private Vector3 turnDirection;
    [SerializeField]
    private Vector3 turnLeft;
    [SerializeField]
    private Vector3 turnRight;

    private void Awake()
    {
        turnLeft = new Vector3(0f, -90f, 0f);
        turnRight = new Vector3(0f, 90f, 0f);
    }

    public void MoveForward()
    {
        // Move forward [along the gameobject's Z axis] at a certain speed
        moveTo = transform.forward * Time.deltaTime * movementSpeed;
        characterController.Move(moveTo); // this move is constrained by collisons in the environment
    }

    [Tooltip("Type in either \"L\" or \"R\"")]
    public void Turn(string direction)
    {
        // Rotate [along the gameobject's Y axis] to the left by -90°, or to the right by 90°
        turnDirection = direction == "L" ? turnLeft : turnRight;
        transform.Rotate(turnDirection * Time.deltaTime * movementSpeed, Space.World);

        /*
        turnAngle = direction == "L" ? -90f : 90f;
        transform.Rotate(0f, turnAngle, 0f, Space.World);
        */
    }
}
