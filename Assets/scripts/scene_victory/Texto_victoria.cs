using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto_victoria : MonoBehaviour
{
    public float tiempo_vida = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo_vida -= Time.deltaTime;
        if (tiempo_vida <= 0)
        {
            Destroy(this.gameObject);
        }
        
    }
}
