using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decision : MonoBehaviour
{
    [SerializeField] Animator letterAnimation; 
    [SerializeField] Text playerNameYes; 
    [SerializeField] Text playerNameNo;
    [SerializeField] 
    Text playerNameFirma;

    private void Start()
    {
        playerNameYes.text = PlayerData.playerName;
        playerNameNo.text = PlayerData.playerName;
        playerNameFirma.text = PlayerData.playerName;
        playerNameYes.enabled = false;
        playerNameNo.enabled = false;
        playerNameFirma.enabled = false;
    }

    //Activado al apretar el botón de sí
    public void YesDecision()
    {
        //Debug.Log("Mi decision fue si");
        playerNameYes.enabled = true;        
        letterAnimation.Play("LetterOut");
    }

    //Activado al apretar el botón de no
    public void NoDecision()
    {
        //Debug.Log("Mi decision fue no");
        playerNameNo.enabled = true;        
        letterAnimation.Play("LetterOut");
        letterAnimation.SetBool("Derrota", GameMaster.derrota);
    }

    public void Firma()
    {
        //Debug.Log("Mi decision fue no");
        playerNameFirma.enabled = true;        
        letterAnimation.Play("LetterOut");
        letterAnimation.SetBool("Derrota", GameMaster.derrota);
    }

public void ResetContract()
    {
        ResetName();
        ResetPetition();
    }

    public void ResetName()
    {
        playerNameYes.enabled = false;
        playerNameNo.enabled = false;
        playerNameFirma.enabled = false;
    }

    public void ResetPetition()
    {
        FindObjectOfType<NextContract>().SelectNextContract();
    }
}
