using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] points = {10, 40, 50, 70, 100};
        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }

        for (int i = 1; i <= points.Length; i++)
        {
            int j = points.Length-i;
            Debug.Log(points[j]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
