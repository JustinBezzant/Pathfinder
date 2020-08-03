using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multi_Display_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
            if (i > 1)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
