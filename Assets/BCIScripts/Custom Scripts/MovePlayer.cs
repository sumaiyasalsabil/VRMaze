using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    private Vector3 turnDirection;
    private Vector3 turnLeft;
    private Vector3 turnRight;

    private void Awake()
    {
        movementSpeed = 1.0f;
        turnLeft = new Vector3(0, -1, 0);
        turnRight = new Vector3(0, 1, 0);
    }

    public void MoveForward()
    {
        // Move forward [along the gameobject's Z axis] at a certain speed
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }

    [Tooltip("Type in either \"L\" or \"R\"")]
    public void Turn(string direction)
    {
        // Rotate [along the gameobject's Y axis] to the left by -90°, or to the right by 90°
        turnDirection = direction == "L" ? turnLeft : turnRight;
        transform.Rotate(turnDirection * Time.deltaTime * movementSpeed, Space.World);
    }
}
