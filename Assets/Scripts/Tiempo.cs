using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tiempo : MonoBehaviour
{
    public TextMeshProUGUI textoCronometro;
    private float tiempoTranscurrido = 0;
    private bool estaCorriendo = true;

    void Start()
    { 
        while (estaCorriendo == true)
        {
            tiempoTranscurrido += Time.deltaTime;
            Cronometro();
        }
    }
        void Cronometro()
    {
       
        textoCronometro.text = "Tiempo: "+ tiempoTranscurrido.ToString("f2");
    }   
}
