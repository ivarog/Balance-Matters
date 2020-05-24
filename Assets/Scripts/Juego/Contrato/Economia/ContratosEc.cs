using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContratosEc : Contrato
{
    public static List<Contrato> contratosEconomia = new List<Contrato>();

    void Awake() {
        /*
         * Indices en el array de int
         * 0 Medio ambiente
         * 1 Energía
         * 2 Economía
         * 3 Felicidad
         */

        /*
        //
        contratosEconomia.Add(new Contrato()
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
        contratosEconomia.Add(new Contrato()
        {
            id = 11,
            textoContrato = "Construir más casas para los foráneos.",
            consecuenciasSi = new int[4] { -5, -5, 5, 5},
            consecuenciasNo = new int[4] { 2, 0, -1, -1},
            textoDescriptivoSi = "¡Bien hecho, ahora hay más habitantes felices con sus nuevos hogares!, sin embargo, se necesitaron fabricar muchos ladrillos.",
            textoDescriptivoNo = "Los foráneos se inconformaron, pero nuestra ciudad no soporta más contaminación.",
            pasado = true,
            presente = true,
            futuro = false
        });

        //2
        contratosEconomia.Add(new Contrato()
        {
            id = 12,
            textoContrato = "Talar más árboles para la industria.",
            consecuenciasSi = new int[4] { -3, 0, 3, 0},
            consecuenciasNo = new int[4] { 3, 0, -4, 1},
            textoDescriptivoSi = "¡Nuestra economía ha aumentado!, sin embargo ha disminuido la cantidad de árboles, y por lo tanto se está acumulando el dióxido de carbono que emitimos.",
            textoDescriptivoNo = "¡Excelente! Dejamos nuestros secuestradores de carbono naturales, a costa de nuestra ecnonomía.",
            pasado = true,
            presente = true,
            futuro = false
        });

        //3
        contratosEconomia.Add(new Contrato()
        {
            id = 13,
            textoContrato = "Crear más fábricas de productos.",
            consecuenciasSi = new int[4] { -5, -2, 5, 2},
            consecuenciasNo = new int[4] { 2, 0, -4, 2},
            textoDescriptivoSi = "¡Excelente, los habitantes están felices de comprar cosas nuevecitas!, nuestra economia es mejor sin embargo una fábrica necesita quemar combustibles fósiles.",
            textoDescriptivoNo = "La gente está feliz porque estamos mejorando su salud respiratoria pero la economía va en picada",
            pasado = true,
            presente = true,
            futuro = false
        });

        //4
        contratosEconomia.Add(new Contrato()
        {
            id = 14,
            textoContrato = "Construir una granja para exportar carne a otros lados.",
            consecuenciasSi = new int[4] { -4, -3, 5, 2},
            consecuenciasNo = new int[4] { 0, 0, -1, 1},
            textoDescriptivoSi = "¡Vaya! Parecía buena idea pero las vacas son un importante emisor de gases de efecto invernadero.",
            textoDescriptivoNo = "¡Excelente! La gente parece felíz de que no talaste sus aldeas.",
            pasado = true,
            presente = true,
            futuro = true
        });

        //5
        contratosEconomia.Add(new Contrato()
        {
            id = 15,
            textoContrato = "Bajar el precio de los productos.",
            consecuenciasSi = new int[4] { -6, -2, 5, 3},
            consecuenciasNo = new int[4] { 4, 0, -3, -1},
            textoDescriptivoSi = "Estás vendiendo más y la gente ama comprar, pero ésto le está costando mucho al ambiente.",
            textoDescriptivoNo = "¡Excelente! Estás cuidando tu ambiente. Tu población es un poco infeliz pero tienen lo que necesitan.",
            pasado = true,
            presente = true,
            futuro = true
        });

        //6
        contratosEconomia.Add(new Contrato()
        {
            id = 16,
            textoContrato = "Aumentar los impuestos, sin consultas y sin satisfacer necesidades",
            consecuenciasSi = new int[4] { 5, -1, 0, -4},
            consecuenciasNo = new int[4] { 0, 0, -5, 5},
            textoDescriptivoSi = "La gente está muy infeliz porque su calidad de vida no mejora, pero tus recursos aumentan.",
            textoDescriptivoNo = "La gente es muy felíz de no tener que contribuir más, pero nuestra ciudad no puede crecer",
            pasado = true,
            presente = true,
            futuro = false
        });

        //7
        contratosEconomia.Add(new Contrato()
        {
            id = 17,
            textoContrato = "Crear nuevos impuestos, sin decir para qué",
            consecuenciasSi = new int[4] { 0, -1, 4, -3},
            consecuenciasNo = new int[4] { 0, 0, -4, 4},
            textoDescriptivoSi = "La gente está molesta de pagar un nuevo impuesto y ni siquiera saber para qué.",
            textoDescriptivoNo = "La gente está contenta de no pagar el nuevo impuesto, pero lo cierto es que tu ciudad necesitaba ese dinero.",
            pasado = false,
            presente = true,
            futuro = true
        });

        //8
        contratosEconomia.Add(new Contrato()
        {
            id = 18,
            textoContrato = "La gente quiere más productos [pero escasean]. Aumentar la producción de las fábricas.",
            consecuenciasSi = new int[4] { -6, -3, 5, 4},
            consecuenciasNo = new int[4] { 3, 2, -4, -1},
            textoDescriptivoSi = "¡Genial! Tu economía sigue creciendo y realmente tu pueblo necesitaba más productos; pero una fábrica necesita quemar combustibles fósiles para producir cosas",
            textoDescriptivoNo = "Le haces un gran favor al ambiente pero tu economía va en picada. Y realmente tu pueblo necesitaba los productos",
            pasado = true,
            presente = true,
            futuro = false
        });

        //9
        contratosEconomia.Add(new Contrato()
        {
            id = 19,
            textoContrato = "Crear más campos de sembradíos y talar árboles para esto.",
            consecuenciasSi = new int[4] { -2, -1, 2, 1},
            consecuenciasNo = new int[4] { 0, 0, -1, 1},
            textoDescriptivoSi = "¡Grandioso, podemos producir más comida! Esto mejoró nuestra economía, a costa de los árboles.",
            textoDescriptivoNo = "De acuerdo; aunque esto afecte un poco nuestra economía, los habitantes agradecen que se conservarán los árboles.",
            pasado = true,
            presente = true,
            futuro = false
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
