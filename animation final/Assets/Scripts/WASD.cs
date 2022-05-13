using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//old input system; swapped key inputs

public class WASD : MonoBehaviour
{
    [SerializeField]
    public float speed;

    [SerializeField]
    public float rotationAngle;

    public bool canMove;

    void Start()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove) //if true
        {
            if (Input.GetKey(KeyCode.W)) //Z on fr
            {
                transform.position = transform.position + transform.forward * Time.deltaTime * speed; //set position to current + forward amount (forward * deltaTime); deltaTime = time passed since last frame, cancels out framerate impact, neutralises = guarantees player moves consistently across frames, framerate independent
            }

            if (Input.GetKey(KeyCode.A)) //Q on ENG keyboard
            {
                transform.Rotate(new Vector3(0, -rotationAngle * Time.deltaTime, 0));
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, rotationAngle * Time.deltaTime, 0));
            }
        }
    }

    public void SetCanMove()
    {
        canMove = true;
    }

    public void DisableCanMove()
    {
        canMove = false;
    }
}
