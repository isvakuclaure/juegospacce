using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton_click : MonoBehaviour
{
   public  void Iniciar()
    {
        SceneManager.LoadScene("juego");
    }
}
