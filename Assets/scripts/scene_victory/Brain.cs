using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public GameObject Textovictoria;
    public void Start()
    {
        MostrarTexto();
    }

    public void MostrarTexto()
    {
        GameObject texto = Instantiate(Textovictoria);
        texto.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);

    }
}
