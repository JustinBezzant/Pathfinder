using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float maxZoom;
    public float maxZoomOut;
    public float scrollSpeed;
    private float cameraMove;
    private Vector3 mousePos;

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0) == true)
        {
            mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z - maxZoom));
            print(mousePos);
            print(transform.position);
            print(Vector3.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, maxZoom)), scrollSpeed));

        }
        if (Input.mouseScrollDelta.y > 0)
        {
            cameraMove = new Vector3((mousePos.x + transform.position.x) / 2, (mousePos.y + transform.position.y) / 2, (maxZoom + transform.position.z) / 2);
            transform.Translate(cameraMove);
        }*/
        if (Input.mouseScrollDelta.y > 0)
        {
            cameraMove = -1f * scrollSpeed;
            if (transform.position.z > maxZoom)
            {
                transform.Translate(new Vector3(0, -1 * scrollSpeed, 0));
            }
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            cameraMove = scrollSpeed;
            if (transform.position.z < maxZoomOut)
            {
                transform.Translate(new Vector3(0, scrollSpeed, 0));
            }
        }
    }
}
