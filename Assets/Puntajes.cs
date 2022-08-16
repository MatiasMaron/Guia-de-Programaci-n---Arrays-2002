using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntajes : MonoBehaviour
{
    [SerializeField] int[] arrayDePuntajes = new int[10];

    void Start()
    {
        Debug.Log("El mayor puntaje es " + ObtenerMayorPuntaje());
        Debug.Log("El indice del nivel con menor puntaje es: " + ObtenerNivelDeMenorPuntaje());
        Debug.Log("El puntaje promedio es: " + ObtenerPuntajePromedio());
    }

    int ObtenerMayorPuntaje()
    {
        int nroMayor = 0;

        foreach(int num in arrayDePuntajes)
        {
            if (num > nroMayor)
            {
                nroMayor = num;
            }
        }

        return nroMayor;
    }

    int ObtenerNivelDeMenorPuntaje()
    {
        int indiceNivel = 0;
        int menorPuntaje = arrayDePuntajes[0];
        for(int i = 1;i < arrayDePuntajes.Length; i++)
        {
            if(arrayDePuntajes[i] < menorPuntaje)
            {
                indiceNivel = i;
                menorPuntaje = arrayDePuntajes[i];
            }
        }

        return indiceNivel;
    }

    float ObtenerPuntajePromedio()
    {
        float ptjPromedio = 0;
        float ptjPromedioFinal = 0;
        foreach(int num in arrayDePuntajes)
        {
            ptjPromedio += num;
        }
        ptjPromedioFinal = ptjPromedio / arrayDePuntajes.Length;

        return ptjPromedioFinal;
    }  
}
