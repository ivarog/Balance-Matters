using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PieGraph : MonoBehaviour
{

    //Medio ambiente 0
    //Energía        1
    //Economía       2
    //Felidad        3
    
    public float[] values;
    [SerializeField] Color[] wedgeColors;
    [SerializeField] Image wedgePrefab;
    [SerializeField]
    Animator letterAnimation;

    private

    void Start()
    {
        MakeGraph();
    }

    public void RecalculateGraph(int[] newValues)
    {
        // Debug.Log("Nuevos Valores");
        for(int i = 0; i < values.Length; i++)
        {
            values[i] += (float)newValues[i];
            // Debug.Log(values[i]);
            if (values[i] <= 0)
            {
                GameMaster.derrota = true;
                //letterAnimation.SetBool("Derrota", GameMaster.derrota);
            }
        }
        MakeGraph();
    }

    public void MakeGraph()
    {
        float totalSum = 0f;
        float zRotation = 0f;

        for(int i = 0; i < values.Length; i++)
        {
            totalSum += values[i];
        }
        

        for(int i = 0; i < values.Length; i++)
        {
            Image newWedge = Instantiate(wedgePrefab) as Image;
            newWedge.transform.SetParent(transform, false);
            newWedge.color = wedgeColors[i];
            newWedge.fillAmount = values[i] / totalSum;
            newWedge.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, zRotation));
            zRotation -= newWedge.fillAmount * 360f;
        }
    }
}
