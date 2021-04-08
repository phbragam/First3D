using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlane : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public float speed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float rotationZ = Input.GetAxis("HorizontalZ") * rotationSpeed * Time.deltaTime;

        float translateZ = Input.GetAxis("VerticalY") * speed * Time.deltaTime;

        transform.Rotate(rotationX, 0, 0);
        transform.Rotate(0, rotationY, 0);
        transform.Rotate(0, 0, rotationZ);

        // transform.Rotate(rotationX, rotationY, rotationZ);

        transform.Translate(0, 0, translateZ);

        Debug.Log("Transform.right: " + transform.right);
        Debug.Log("Transform.up: " + transform.up);
        Debug.Log("Transform.forward: " + transform.forward);
    }
}
