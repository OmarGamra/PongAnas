using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{
    // Start is called before the first frame update
        void Start()
    {
        Debug.Log(Sum(1,2));
        Debug.Log(Prod(6,3));
        Debug.Log(Div(5,7));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Sum(int a, int b)
    {
        return a + b;
    }
    float Prod(int a, int b)
    {
        return a * b;
    }
    float Div(int a, int b)
    { 
        if(b == 0)
        { Debug.Log("ERROR");
            return 0;
        }
        else return a / b;
        }
}
