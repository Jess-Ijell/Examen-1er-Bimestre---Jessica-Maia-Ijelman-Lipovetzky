﻿//Vamos a programar un algoritmo que permita al usuario convertir una cantidad de dinero en
//pesos argentinos a su equivalente en moneda extranjera.
//Se debe poder ingresar por Inspector el monto a convertir
//y una letra correspondiente a la moneda extranjera que se quiere convertir, las opciones son:

//D, para dólares
//R, para reales
//E, para euros

//(La cotización de la moneda será investigada por quien realice el examen).

//El programa debe cumplir los siguientes requerimientos:
//Si se ingresa otra cosa que no sea “D”, “R” o “E” se debe mostrar el mensaje “Opción de moneda extranjera no válida”.

//Si la cantidad de dinero de dinero a convertir es menor que 1000, mostrar el mensaje “El monto mínimo es $1000”. 

//Si los valores ingresados son válidos devolver el mensaje 
//"[monto a convertir] pesos argentinos equivalen a [cantidad covertida] [moneda elegida] ".
//Ejemplo: "1000 pesos equivalen a 3 dólares".

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsignaTema1 : MonoBehaviour
{

    public float MontoEnPesos;
    public string MonedaAConvertir;

    // Start is called before the first frame update
    void Start()
    {
        if (MontoEnPesos >= 1000)
        {
            if (MonedaAConvertir == "D")
            {
                Debug.Log(MontoEnPesos + " pesos argentinos equivalen a " + (MontoEnPesos / 112.6) + MonedaAConvertir);
            }

            else if (MonedaAConvertir == "R")
            {
                Debug.Log(MontoEnPesos + " pesos argentinos equivalen a " + (MontoEnPesos / 23.86) + MonedaAConvertir);
            }

            else if (MonedaAConvertir == "E")
            {

                Debug.Log(MontoEnPesos + " pesos argentinos equivalen a " + (MontoEnPesos / 122.62) + MonedaAConvertir);
            }

            else
            {
                Debug.Log("Opción de moneda extranjera no válida");
            }
        }

        else
        {
            Debug.Log("El monto mínimo es $1000");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
