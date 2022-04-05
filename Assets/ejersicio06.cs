using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejersicio06 : MonoBehaviour
{
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 % 2 == 1)
        {
            Debug.Log("el numero es impar");
        }
        else if (num1 % 2 == 0)
        {
            Debug.Log("el numero es par");
        }
        else
        {
            Debug.Log("error: el valor no es mayor a 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
