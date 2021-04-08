using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float speed = 100.0f;
    public float rotationSpeed = 100.0f;

    Vector3 up;
    Vector3 forward;
    Vector3 side;

    //private void Start()
    //{
    //    transform.Translate(100, 0, 0);
    //    transform.position = HolisticMath.Translate(transform.position, transform.right, 100);
    //    Debug.Log(transform.right);
    //}

    void Update()
    {
        side = transform.right;
        up = transform.up;
        forward = transform.forward;

        float translateX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float translateY = Input.GetAxis("VerticalY") * speed * Time.deltaTime;
        float translateZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // This makes the airplane goes up and down on its own axis, because I multiply the translate by each axis normalized
        // before adding to transform.position (inside HolisticMath.Translate()):

        //transform.position = HolisticMath.Translate(transform.position, side, translateX);
        //transform.position = HolisticMath.Translate(transform.position, up, translateY);
        //transform.position = HolisticMath.Translate(transform.position, forward, translateZ);

        // Unity's built in translate also do the same :

        transform.Translate(translateX, 0, 0);
        transform.Translate(0, translateY, 0);
        transform.Translate(0, 0, translateZ);

        // This makes the airplane goes up and down independent of its own rotations, because here I only add a value on each
        // componente of transform.position (independent of changes in transform.right, transform.up and transform.forward):

        //transform.position = new Vector3(transform.position.x + translateX,
        //                                    transform.position.y + translateY,
        //                                    transform.position.z + translateZ);
    }
}
