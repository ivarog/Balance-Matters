using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static List<Contrato> todosLosContratos = new List<Contrato>();

    public static List<Contrato> contratosPasado = new List<Contrato>();
    public static List<Contrato> contratosPresente = new List<Contrato>();
    public static List<Contrato> contratosFuturo = new List<Contrato>();

    public static bool derrota;
    void Awake()
    {
        derrota = false;

        //Contratos Pasados 17
        for (int i = 0; i < ContratosMA.contratosMA.Count; i++)
        {
            if (ContratosMA.contratosMA[i].pasado)
            {
                contratosPasado.Add(ContratosMA.contratosMA[i]);
            }
        }

        for (int i = 0; i < ContratosEn.contratosEnergia.Count; i++)
        {
            if (ContratosEn.contratosEnergia[i].pasado)
            {
                contratosPasado.Add(ContratosEn.contratosEnergia[i]);
            }
        }

        for (int i = 0; i < ContratosEc.contratosEconomia.Count; i++)
        {
            if (ContratosEc.contratosEconomia[i].pasado)
            {
                contratosPasado.Add(ContratosEc.contratosEconomia[i]);
            }
        }

        for (int i = 0; i < ContratosF.contratosFelicidad.Count; i++)
        {
            if (ContratosF.contratosFelicidad[i].pasado)
            {
                contratosPasado.Add(ContratosF.contratosFelicidad[i]);
            }
        }

        // Debug.Log(contratosPasado.Count);

        //Contratos Presente 32
        for (int i = 0; i < ContratosMA.contratosMA.Count; i++)
        {
            if (ContratosMA.contratosMA[i].presente)
            {
                contratosPresente.Add(ContratosMA.contratosMA[i]);
            }
        }

        for (int i = 0; i < ContratosEn.contratosEnergia.Count; i++)
        {
            if (ContratosEn.contratosEnergia[i].presente)
            {
                contratosPresente.Add(ContratosEn.contratosEnergia[i]);
            }
        }

        for (int i = 0; i < ContratosEc.contratosEconomia.Count; i++)
        {
            if (ContratosEc.contratosEconomia[i].presente)
            {
                contratosPresente.Add(ContratosEc.contratosEconomia[i]);
            }
        }

        for (int i = 0; i < ContratosF.contratosFelicidad.Count; i++)
        {
            if (ContratosF.contratosFelicidad[i].presente)
            {
                contratosPresente.Add(ContratosF.contratosFelicidad[i]);
            }
        }

        // Debug.Log(contratosPresente.Count);

        //Contratos Futuro 25
        for (int i = 0; i < ContratosMA.contratosMA.Count; i++)
        {
            if (ContratosMA.contratosMA[i].futuro)
            {
                contratosFuturo.Add(ContratosMA.contratosMA[i]);
            }
        }

        for (int i = 0; i < ContratosEn.contratosEnergia.Count; i++)
        {
            if (ContratosEn.contratosEnergia[i].futuro)
            {
                contratosFuturo.Add(ContratosEn.contratosEnergia[i]);
            }
        }

        for (int i = 0; i < ContratosEc.contratosEconomia.Count; i++)
        {
            if (ContratosEc.contratosEconomia[i].futuro)
            {
                contratosFuturo.Add(ContratosEc.contratosEconomia[i]);
            }
        }

        for (int i = 0; i < ContratosF.contratosFelicidad.Count; i++)
        {
            if (ContratosF.contratosFelicidad[i].futuro)
            {
                contratosFuturo.Add(ContratosF.contratosFelicidad[i]);
            }
        }

        //Superlista
        todosLosContratos.AddRange(contratosPasado);
        todosLosContratos.AddRange(contratosPresente);
        todosLosContratos.AddRange(contratosFuturo);

        // Debug.Log(contratosFuturo.Count);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
