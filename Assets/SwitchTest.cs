using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a, b;
        a = 10;
        b = 12;
        if (a<b)
        {
            Debug.Log("a is less than b");
        }
        else
        {
            Debug.Log("a isn't less than b");
            Debug.Log("a still isn't less than b");
        }

        int testvalue = 1;
        switch (testvalue)
        {
            case 1:
                Debug.Log("testvalue is 1");
                break;
            case 2:
                Debug.Log("testvalue is 2");
                break;
            default:
                Debug.Log("testvalue default");
                break;
        }

        Debug.Log("End of start method");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
