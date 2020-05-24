using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContratosEn : MonoBehaviour
{
    public static List<Contrato> contratosEnergia = new List<Contrato>();

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
        contratosEnergia.Add(new Contrato()
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
        contratosEnergia.Add(new Contrato()
        {
            id = 20,
            textoContrato = "Crear una planta de combustóleo.",
            consecuenciasSi = new int[4] { -7, 5, 0, 2 },
            consecuenciasNo = new int[4] { 0, 0, 3, -3 },
            textoDescriptivoSi = "Tenemos mucho combustóleo y saldrá rentable el negocio pero este combustible fósil es altamente contaminante.",
            textoDescriptivoNo = "La gente está muy feliz de no tener que tener en su nariz ese humo negro, pero tenemos una empresa menos de electricidad por lo que no tenemos que vender para mantenernos.",
            pasado = true,
            presente = false,
            futuro = false
        });

        //2
        contratosEnergia.Add(new Contrato()
        {
            id = 21,
            textoContrato = "Crear plantas de gas natural.",
            consecuenciasSi = new int[4] { -2, 6, -4, 0 },
            consecuenciasNo = new int[4] { 0, -1, 1, 0 },
            textoDescriptivoSi = "Vaya, este combustible es menos contaminante pero sigue siendo un combustible fósil, y si se nos escapa, igual es un gas de efecto invernadero",
            textoDescriptivoNo = "¡Vaya! Nos ahorramos dinero por ahora y tenemos menos energía porque nuestras viejas plantas están dejando de funcionar.",
            pasado = true,
            presente = true,
            futuro = false
        });

        //3
        contratosEnergia.Add(new Contrato()
        {
            id = 21,
            textoContrato = "Crear granja solar, sin remover a nadie porque no hay gente en ese lugar.",
            consecuenciasSi = new int[4] { 2, 2, -4, 0 },
            consecuenciasNo = new int[4] { -2, 0, 2, 0 },
            textoDescriptivoSi = "Aprovechaste muy bien este espacio, cuidarás el medio ambiente pero será más costoso que una planta de combustibles fósiles.",
            textoDescriptivoNo = "Te ahorraste dinero, pero seguimos contaminando al  generar electricidad con combustibles fósiles",
            pasado = false,
            presente = true,
            futuro = true
        });

        //4
        contratosEnergia.Add(new Contrato()
        {
            id = 22,
            textoContrato = "Insertar secuestradores de carbono.",
            consecuenciasSi = new int[4] { 5, -2, -3, 0 },
            consecuenciasNo = new int[4] { -6, 3, 3, 0 },
            textoDescriptivoSi = "¡Vaya! Eliminaste uno de tus grandes problemas, las emisiones de tus plantas de generación y fábricas. Aparte puedes aprovechar el dióxido de carbono para otros procesos.",
            textoDescriptivoNo = "Aunque te ahorraste dinero, estás dañando fuertemente el ambiente. Seguro que en el futuro costará mucho más.",
            pasado = false,
            presente = false,
            futuro = true
        });

        //5
        contratosEnergia.Add(new Contrato()
        {
            id = 23,
            textoContrato = "Crear una planta nuclear.",
            consecuenciasSi = new int[4] { 4, 6, -2, -8 },
            consecuenciasNo = new int[4] { 0, -4, 0, +4 },
            textoDescriptivoSi = "Esta planta genera mucha energía con poco; pero la gente tiene mucho miedo.",
            textoDescriptivoNo = "Evitaste protestas interminables del pueblo; pero ya no tienes energía porque tus viejas plantas están dejando de funcionar.",
            pasado = false,
            presente = true,
            futuro = true
        });

        //6
        contratosEnergia.Add(new Contrato()
        {
            id = 24,
            textoContrato = "Planta de cogeneración.",
            consecuenciasSi = new int[4] { 2, 5, -4, -3 },
            consecuenciasNo = new int[4] { 2, 0, -3, 1 },
            textoDescriptivoSi = "Parece una excelente opción, podemos usar el calor que las plantas de generación no utilizan. Así ya no quemamos más combustible para calentar el agua del baño, por ejemplo",
            textoDescriptivoNo = "Está desaprovechando la energía térmica de las plantas, tendrás que usar más combustible para generar calor que necesitas en otros procesos.",
            pasado = false,
            presente = true,
            futuro = true
        });

        //7
        contratosEnergia.Add(new Contrato()
        {
            id = 25,
            textoContrato = "Instalar un parque eólico y quitar una granja.",
            consecuenciasSi = new int[4] { 2, 4, -2, -4},
            consecuenciasNo = new int[4] { 0, -2, 0, 2},
            textoDescriptivoSi = "¡Genial! Estas generando electricidad con energías limpias, redujiste tus emisiones; pero es más costoso y la gente que vivía en el área está muy enojada porque le quitaste sus hogares.",
            textoDescriptivoNo = "¡Vaya! Los habitantes del lugar dónde querías poner tu parque eólico se sienten aliviados de no perder sus casas, pero tu población necesita electricidad.",
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
