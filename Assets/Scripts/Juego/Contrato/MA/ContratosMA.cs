using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContratosMA : MonoBehaviour
{
    public static List<Contrato> contratosMA = new List<Contrato>();

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
        contratosMA.Add(new Contrato()
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
         contratosMA.Add(new Contrato()
        {
            id = 1,
            textoContrato = "Mantenimiento a plantas de generación.",
            consecuenciasSi = new int[4] { 3, 2, -5, 0},
            consecuenciasNo = new int[4] { -1, -1, -1, 3},
            textoDescriptivoSi = "¡Muy bien! Ya no necesitamos quemar tanto petróleo para generar la electricidad que necesitamos.",
            textoDescriptivoNo = "¡Vaya! ahorrarás dinero, que felicidad pero gastaras más combustóleo para generar energía.",
            pasado = false,
            presente = true,
            futuro = true
        });

        //2
        contratosMA.Add(new Contrato()
        {
            id = 2,
            textoContrato = "Normas para que los refris sean más eficientes.",
            consecuenciasSi = new int[4] { 3, 0, -2, -1},
            consecuenciasNo = new int[4] { -1, -1, -1, 3},
            textoDescriptivoSi = "Excelente, nos costará algo pero consumiremos menos energía y se quemarán menos fósiles.",
            textoDescriptivoNo = "¡Vaya! ahorrarás dinero, pero la cuenta de la compañía de electricidad nos arruinará a todos.",
            pasado = false,
            presente = true,
            futuro = true
        });

        //3
        contratosMA.Add(new Contrato()
        {
            id = 3,
            textoContrato = "Programa de cambio de focos.",
            consecuenciasSi = new int[4] { 2, 0, -1, -1},
            consecuenciasNo = new int[4] { -1, -1, 0, 2},
            textoDescriptivoSi = "¡Vaya! ahorrarás dinero, pero la cuenta de la compañía de electricidad nos arruinará a todos",
            textoDescriptivoNo = "¡Vaya! ahorrarás dinero, pero la cuenta de la compañía de electricidad nos arruinará a todos, además quemaremos más",
            pasado = false,
            presente = true,
            futuro = true
        });

        //4
        contratosMA.Add(new Contrato()
        {
            id = 4,
            textoContrato = "Hacer más eficiente el sistema de transporte  público, con previa consulta ciudadana.",
            consecuenciasSi = new int[4] { 3, 0, -5, 2},
            consecuenciasNo = new int[4] { -3, 0, 5, -2},
            textoDescriptivoSi = "Qué bien que preguntaste antes, así la gente parece más feliz aunque vaya que costó. Además el cielo parece más azul.",
            textoDescriptivoNo = "El cielo se ve cada vez más negro, nuestra economía va bien pero la gente está tan molesta que no tiene ánimos de nada",
            pasado = false,
            presente = true,
            futuro = true
        });

        //5
        contratosMA.Add(new Contrato()
        {
            id = 5,
            textoContrato = "Promover políticas de separación de residuos sólidos.",
            consecuenciasSi = new int[4] { 3, -1, -2, 0},
            consecuenciasNo = new int[4] { -3, 1, 1, 1},
            textoDescriptivoSi = "Vaya, el cielo parece más limpio y la ciudad también.",
            textoDescriptivoNo = "Pronto no habrá espacio para nosotros, la basura está llenando nuestra ciudad y el cielo se ve más negro.",
            pasado = false,
            presente = true,
            futuro = true
        });

        //6
        contratosMA.Add(new Contrato()
        {
            id = 6,
            textoContrato = "Se necesita reforestar una zona con árboles de la misma especie.",
            consecuenciasSi = new int[4] { 4, 0, -5, 1},
            consecuenciasNo = new int[4] { -3, 0, 5, -2},
            textoDescriptivoSi = "Esto nos ayudará a limpiar un poco el cielo, de hecho volvimos a ver las estrellas. Nos costó mucho pero valió la pena",
            textoDescriptivoNo = "Cada vez hay menos sitios bonitos a dónde mirar y la ciudad se pone gris.",
            pasado = true,
            presente = true,
            futuro = true
        });

        //7
        contratosMA.Add(new Contrato()
        {
            id = 7,
            textoContrato = "Invertir para Gestión de residuos.",
            consecuenciasSi = new int[4] { 10, -5, -5, 0},
            consecuenciasNo = new int[4] { -8, 0, 8, 0},
            textoDescriptivoSi = "En nuestra ciudad ya no hay basura, solo residuos y los podremos manejar de una mejor manera para que no duren mucho en nuestro planeta.",
            textoDescriptivoNo = "Ahorramos mucho dinero solo arrojando basura al mar o quemándola pero nuestra ciudad se ve cada vez peor.",
            pasado = false,
            presente = true,
            futuro = true
        });

        //8
        contratosMA.Add(new Contrato()
        {
            id = 8,
            textoContrato = "Implementar programas de reducción de uso vehicular.",
            consecuenciasSi = new int[4] { 7, 0, -2, -5},
            consecuenciasNo = new int[4] { 2, 0, 0, -2},
            textoDescriptivoSi = "La gente está muy enojada, pero ahora podemos respirar mejor.",
            textoDescriptivoNo = "La población está muy feliz de llevar su auto a la tiendita de la esquina; pero esto cada vez está peor, nadie puede respirar.",
            pasado = false,
            presente = true,
            futuro = true
        });

        //9
        contratosMA.Add(new Contrato()
        {
            id = 9,
            textoContrato = "Crear campañas de concientización para reducir consumismo.",
            consecuenciasSi = new int[4] { 6, 0, -3, -3},
            consecuenciasNo = new int[4] { -5, -2, 4, 3},
            textoDescriptivoSi = "Si",
            textoDescriptivoNo = "No",
            pasado = false,
            presente = true,
            futuro = true
        });

        //10
        contratosMA.Add(new Contrato()
        {
            id = 10,
            textoContrato = "Reciclar el papel.",
            consecuenciasSi = new int[4] { 2, -1, -1, 0},
            consecuenciasNo = new int[4] { -2, 0, 1, 1},
            textoDescriptivoSi = "La gente parece entender que lo importante es la funcionalidad de las cosas y no que tan bien se ven.",
            textoDescriptivoNo = "Todo se ve más negro y hay más basura, pero la gente se ve muy felíz con nuevo celular y vaya que estas fábricas nos están dejando dinero",
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
