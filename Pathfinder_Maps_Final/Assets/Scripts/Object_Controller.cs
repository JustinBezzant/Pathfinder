using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask Targetable;
    public float TokenPositions;
    private GameObject Selected;
    void Start()
    {
        Selected = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit,Mathf.Infinity,Targetable))
            {
                Selected = hit.collider.gameObject;
                Debug.Log(hit.collider.gameObject);

            }
            
        }
        if (Input.GetMouseButtonDown(1) && Selected != null)
        {
            Debug.Log(Selected);
            Selected.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z - TokenPositions));
            Debug.Log(Camera.main);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void Hide()
    {
        Debug.Log(Selected.name);
        Debug.Log(LayerMask.LayerToName(8));
        Selected.layer = 8; //GM Layer
    }
    public void Reveal()
    {
        Debug.Log(Selected.name);
        Debug.Log(LayerMask.LayerToName(9));
        Selected.layer = 9; //all Players
    }
}
