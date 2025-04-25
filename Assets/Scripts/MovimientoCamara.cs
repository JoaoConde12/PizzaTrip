using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public Transform objetivo;  // El objetivo es el personaje
    public float velocidadCamara = 0.025f;
    public Vector3 desplazamiento;

    private void LateUpdate()
    {
        Vector3 posicionDeseada = objetivo.position + desplazamiento;
        Vector3 posicionSuavizada = Vector3.Lerp(transform.position, posicionDeseada, velocidadCamara);
        
        transform.position = posicionSuavizada;
    }
}
