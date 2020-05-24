using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContratosF : MonoBehaviour
{
    public static List<Contrato> contratosFelicidad = new List<Contrato>();

    void Awake()
    {
        /*
         * Indices en el array de int
         * 0 Medio ambiente
         * 1 Energía
         * 2 Economía
         * 3 Felicidad
         */

        /*
        //
        contratosFelicidad.Add(new Contrato()
        {
            textoContrato = "",
            consecuenciasSi = new int[4] { , , , },
            consecuenciasNo = new int[4] { , , , },
            textoDescriptivoSi = "Si",
            textoDescriptivoNo = "No",
            pasado = true,
            presente = false,
            futuro = false
        });
        */
        
        //1
        contratosFelicidad.Add(new Contrato()
        {
            id = 26,
            textoContrato = "Crear centros nocturnos para la diversión de la población.",
            consecuenciasSi = new int[4] { -6, -2, 3, 5},
            consecuenciasNo = new int[4] { 2, 0, 0, -2},
            textoDescriptivoSi = "¡Grandioso, los habitantes están muy complacidos!, ahora tienen la opción de divertirse toda la noche, aunque esto está generando un mayor consumo  de electricidad.",
            textoDescriptivoNo = "De acuerdo, algunos habitantes se sienten tranquilos porque podrán dormir tranquilamente.",
            pasado = true,
            presente = true,
            futuro = true
        });

        //2
        contratosFelicidad.Add(new Contrato()
        {
            id = 27,
            textoContrato = "Crear parques infantiles.",
            consecuenciasSi = new int[4] { -4, -3, -3, 10},
            consecuenciasNo = new int[4] { 1, 0, 1, -2},
            textoDescriptivoSi = "¡Excelente, todos los habitantes están super felices!, los niños de nuestra comunidad se divierten y hacen ejercicio fuera de casa, aunque se hizo un gasto considerable. ",
            textoDescriptivoNo = "Bueno, los habitantes conviven dentro de casa con sus niños, pero sin hacer ejercicio, algunos se ven un poco aburridos.",
            pasado = true,
            presente = true,
            futuro = true
        });

        //3
        contratosFelicidad.Add(new Contrato()
        {
            id = 28,
            textoContrato = "Construir cines.",
            consecuenciasSi = new int[4] { -6, -3, 4, 5},
            consecuenciasNo = new int[4] { 3, 1, 0, -4},
            textoDescriptivoSi = "¡Al fin, el cine ha llegado a nuestra comunidad, los habitantes están muy complacidos!, a pesar de que se gastará más electricidad, este proyecto también atraerá recursos a nuestra comunidad.",
            textoDescriptivoNo = "De acuerdo, hay asuntos de mayor prioridad, aunque los habitantes fallen en entenderlo",
            pasado = true,
            presente = true,
            futuro = true
        });

        //4
        contratosFelicidad.Add(new Contrato()
        {
            id = 29,
            textoContrato = "Construir hospitales, la gente los necesita.",
            consecuenciasSi = new int[4] { -5, -3, 0, 8},
            consecuenciasNo = new int[4] { 2, 0, 1, -3},
            textoDescriptivoSi = "¡Finalmente, los habitantes se sienten más tranquilos!, todos entienden que fue un gasto de alta prioridad debido a que la salud tal vez no sea lo más importante pero sin ella lo demás pierde importancia. ",
            textoDescriptivoNo = "Esperemos que nadie se enferme gravemente en un tiempo, los habitantes están preocupados.",
            pasado = true,
            presente = true,
            futuro = true
        });

        //5
        contratosFelicidad.Add(new Contrato()
        {
            id = 30,
            textoContrato = "Reforestar con árboles lindos que no son endémicos.", /*, en zonas áridas sin personas y ahora pueden respirar mejor.*/
            consecuenciasSi = new int[4] { -3, -1, -1, 5},
            consecuenciasNo = new int[4] { 1, 0, 0, -1},
            textoDescriptivoSi = "¡Precioso, los habitantes están muy complacidos!, valio la pena el gasto requerido en este proyecto debido a que la belleza de nuestro paisaje ahora es como para una postal.",
            textoDescriptivoNo = "Bueno, nuestro árboles son lindos pero no para una postal, los habitantes se ven un poco aburridos del paisaje.",
            pasado = false,
            presente = true,
            futuro = true
        });

        //6
        contratosFelicidad.Add(new Contrato()
        {
            id = 31,
            textoContrato = "Constriur teatros.",
            consecuenciasSi = new int[4] { -5, -2, 3, 4},
            consecuenciasNo = new int[4] { 2, 1, 0, -3},
            textoDescriptivoSi = "¡El valor cultural de nuestra comunidad ha aumentado, los habitantes se ven complacidos!, a pesar de que se gastará más electricidad, este proyecto atraerá recursos a nuestra comunidad",
            textoDescriptivoNo = "De acuerdo, hay asuntos de mayor prioridad, aunque los habitantes fallen en entenderlo.",
            pasado = true,
            presente = true,
            futuro = false
        });

        //7
        contratosFelicidad.Add(new Contrato()
        {
            id = 32,
            textoContrato = "Construir más escuelas.",
            consecuenciasSi = new int[4] { 3, -1, -1, -1},
            consecuenciasNo = new int[4] { 1, 0, 0, -1},
            textoDescriptivoSi = "¡Bien hecho, la educación de los jóvenes es lo más importante para toda comunidad y los habitantes están de acuerdo!, fue un gasto considerable pero vale la pena.",
            textoDescriptivoNo = "Bueno, tendremos que continuar con las que tenemos, aunque los habitantes opinan que son pocas.",
            pasado = true,
            presente = true,
            futuro = true
        });

        //8
        contratosFelicidad.Add(new Contrato()
        {
            id = 33,
            textoContrato = "Organizar un Game Jam Climático para hacer difusión cultural sobre el cambio climático.",
            consecuenciasSi = new int[4] { 2, -3, -1, 2},
            consecuenciasNo = new int[4] { -1, 0, 2, -1},
            textoDescriptivoSi = "¡Excelente, los habitantes están muy interesados!, esta es una gran campaña para concientizar a la comunidad y vale la pena el gasto.",
            textoDescriptivoNo = "De acuerdo, hay asuntos de mayor prioridad, aunque los habitantes fallen en entenderlo.",
            pasado = false,
            presente = true,
            futuro = true
        });
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
