using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float transVelUp;
    private float transVelDown;
    private float transVelLeft;
    private float transVelRight;
    public float transAccel;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transVelUp = transVelUp + transAccel;
            gameObject.transform.Translate(0, 0, transVelUp);
        }
        else
        {
            transVelUp = 0;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transVelDown = transVelDown - transAccel;
            gameObject.transform.Translate(0, 0, transVelDown);

        }
        else
        {
            transVelDown = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transVelLeft = transVelLeft - transAccel;
            gameObject.transform.Translate(transVelLeft, 0, 0);

        }
        else
        {
            transVelLeft = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transVelRight = transVelRight + transAccel;
            gameObject.transform.Translate(transVelRight, 0, 0);

        }
        else
        {
            transVelRight = 0;
        }
    }
}
