using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contrato : MonoBehaviour
{
    public int id { get; set; }
    public string textoContrato { get; set; }
    public int[] consecuenciasSi { get; set; }
    public int[] consecuenciasNo { get; set; }
    public string textoDescriptivoSi { get; set; }
    public string textoDescriptivoNo { get; set; }
    public bool pasado { get; set; }
    public bool presente { get; set; }
    public bool futuro { get; set; }
}
