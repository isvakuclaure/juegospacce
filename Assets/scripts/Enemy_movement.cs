using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    public float cycleWidth, frequency, velocity;
    float cY, CX, counter, XsIN;
    private void Start()
    {
        cY = transform.position.y;
        CX = transform.position.x;
    }
    private void Update()
    {
        cY = cY - velocity;
        counter = counter + (frequency/100);
        XsIN = Mathf.Sin(counter);
        transform.position = new Vector3(CX + (XsIN * cycleWidth), cY, 0);
        if(counter > 6.28f)
        {
            counter = 0;
        }


    }
}
