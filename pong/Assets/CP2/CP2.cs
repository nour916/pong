using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CP2 : MonoBehaviour
{

    private void Start()
    {
        Sum(12,15 );
        Prod(10, 20 );
        Div(14, 10);
        
      
    }

    int Sum(int a,int b){

        return a + b;
    }

    int Prod(int a, int b) {

        return a * b;
    }

    int Div(int a, int b)
    {

        if (b == 0)
        {
            Debug.Log("error");
            return 0;
        }
        return a / b;
    }
}








